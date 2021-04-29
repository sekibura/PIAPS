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
        private BlankImage _proxyImage = new BlankImage();
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<KeyValuePair<Image, Rectangle>> _images = new List<KeyValuePair<Image, Rectangle>>();
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string _imagePath = OpenFileDioalogFunc();
            _proxyImage.Path=_imagePath;
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
                {

                    filePath = openFileDialog.FileName;
                }
            }
            return filePath;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (_proxyImage.Path != null && me.Button==MouseButtons.Left)
            {
                AddRect();
                //DrawAll();
            }
        }

        private void AddRect()
        {
            g = panel1.CreateGraphics();
            Rectangle rectangle = new Rectangle(panel1.PointToClient(Cursor.Position), _proxyImage.GetSize());
            Pen pen = new Pen(Color.Red, 3f);
            _rectangles.Add(rectangle);
            g.DrawRectangle(pen, rectangle);
        }

        //private void DrawAll()
        //{
        //    g = panel1.CreateGraphics();
        //    Pen pen = new Pen(Color.Red, 1f);
        //    foreach (Rectangle rectangle in _rectangles)
        //        g.DrawRectangle(pen, rectangle);

        //    foreach(KeyValuePair<Image,Rectangle> image in _images)
        //        g.DrawImage(image.Key, image.Value);
        //}

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Db clck");
            if (_proxyImage.Path != null && e.Button == MouseButtons.Right)
            {
                FillRectImage(panel1.PointToClient(Cursor.Position));
                //DrawAll();
            }
        }

        private void FillRectImage(Point point)
        {
            foreach (Rectangle rectangle in _rectangles)
            {
                if (IsPointInsideRect(rectangle, point))
                {
                    Debug.WriteLine("Inside");
                    Image img;
                    using (Image sourceImage = Image.FromFile(_proxyImage.Path))
                    {
                        Point picPoint = new Point(rectangle.X, rectangle.Y);
                        img = sourceImage;
                        //_images.Add(new KeyValuePair<Image, Rectangle>(Image.FromFile(_proxyImage.Path), rectangle));
                        g.DrawImage(sourceImage, rectangle);
                    }
                    
                }
                else
                {
                    Debug.WriteLine("Outside");
                }
            }
        }

        private bool IsPointInsideRect(Rectangle rectangle, Point point)
        {
            return rectangle.Location.X <= point.X && rectangle.Location.Y <= point.Y && rectangle.Location.X + rectangle.Width >= point.X && rectangle.Location.Y + rectangle.Height >= point.Y;
              
        }
    }

}
