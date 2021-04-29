using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Proxy
{
    public partial class Form1 : Form
    {
        //private RealImage _realImage = new RealImage();
        //private BlankImage _proxyImage;
        private string _path = "";

        //private List<Rectangle> _rectangles = new List<Rectangle>();
        //private List<KeyValuePair<Image, Rectangle>> _images = new List<KeyValuePair<Image, Rectangle>>();

        private List<BlankImage> _images = new List<BlankImage>();

        private WorkMode _workMode = WorkMode.CreateRectangle;

        Graphics g;

        private bool _inMoving;
        private BlankImage _movableImage;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
     
        private string OpenFileDioalogFunc()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Image Files| *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
            }
            return filePath;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (_path != null && me.Button == MouseButtons.Left && _workMode == WorkMode.CreateRectangle)
                CreateImage(me, panel1);
        }

        private void MoveFigure(Point mousePosition)
        {
            if (_movableImage == null)
            {
                for (int i = _images.Count - 1; i >= 0; i--)
                {
                    if (IsPointInsideRect(_images[i], mousePosition))
                    {
                        _movableImage = _images[i];
                        break;
                    }
                }
            }
            else
            {
                Point delta = new Point(mousePosition.X - _movableImage.GetPosition().X, mousePosition.Y - _movableImage.GetPosition().Y);
                Point newPosition = _movableImage.GetPosition();
                newPosition.Offset(delta);
                _movableImage.SetPosition(newPosition);
                DrawAll();
            }

        }

        private void CreateImage(MouseEventArgs mouse, Panel panel)
        {
            RealImage realImage = new RealImage();
            BlankImage blankImage = new BlankImage(realImage);

            blankImage.SetPath(_path);
            blankImage.SetPosition(panel.PointToClient(Cursor.Position));
            g = panel.CreateGraphics();
            blankImage.DrawImage(g, mouse.Button);
            _images.Add(blankImage);
        }


        private void DrawAll()
        {
            g.Clear(Color.White);
            g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 1f);
            foreach (BlankImage image in _images)
            {
                image.DrawImage(g, MouseButtons.Left);
                if (image.IsHavePucture())
                    image.DrawImage(g, MouseButtons.Right);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Db clck");
            if (_path != null && e.Button == MouseButtons.Right)
            {
                Point mousePos = panel1.PointToClient(Cursor.Position);
                foreach (BlankImage image in _images)
                {
                    if (IsPointInsideRect(image, mousePos))
                    {
                        g = panel1.CreateGraphics();
                        image.DrawImage(g, e.Button);
                    }
                }
            }
        }

        private bool IsPointInsideRect(BlankImage image, Point point)
        {
            return image.GetPosition().X <= point.X && image.GetPosition().Y <= point.Y && image.GetPosition().X + image.GetSize().Width >= point.X && image.GetPosition().Y + image.GetSize().Height>= point.Y;
        }

        private void btnCreateMouse_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            _workMode = WorkMode.CreateRectangle;
        }

        private void btnMoveMouse_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.NoMove2D;
            _workMode = WorkMode.Move;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string _imagePath = OpenFileDioalogFunc();
            _path = _imagePath;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (_path != null && me.Button == MouseButtons.Left && _workMode==WorkMode.Move)
                _inMoving = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _inMoving = false;
            _movableImage = null;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (_path != null && me.Button == MouseButtons.Left && _workMode == WorkMode.Move && _inMoving)
                MoveFigure(panel1.PointToClient(Cursor.Position));
        }
    }

}
