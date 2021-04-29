using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab4Proxy
{
    class BlankImage : IImage
    {
        public string Path { get; set; }
        private Point position = new Point();
        private RealImage _realImage;

        public BlankImage(RealImage realImage)
        {
            _realImage = realImage;
        }

        public Size GetSize()
        {
            if (!String.IsNullOrEmpty(Path))
                return GetImageSize(Path);
            
            return new Size(0,0);
        }

        private Size GetImageSize(string path)
        {
            Size size = new Size();
            using (Stream stream = File.OpenRead(path))
            {
                using (Image sourceImage = Image.FromStream(stream, false, false))
                {
                    size.Width = sourceImage.Width;
                    size.Height = sourceImage.Height;
                }
            }
            return size;
        }

        public Point GetPosition()
        {
            return position;
        }

        public void SetPosition(Point point)
        {
            position = point;
            _realImage.SetPosition(point);
        }

        public void DrawImage(Graphics g, MouseButtons button)
        {
            if(button == MouseButtons.Left)
            {
                Rectangle rectangle = new Rectangle(GetPosition(), GetSize());
                Pen pen = new Pen(Color.Red, 3f);
                g.DrawRectangle(pen, rectangle);
            }
            else if(button == MouseButtons.Right)
            {
                _realImage.DrawImage(g, button);
            }
        }
    }
}
