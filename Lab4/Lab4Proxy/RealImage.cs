using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab4Proxy
{
    class RealImage : IImage
    {
        private string _path = "";
        private Point _position;
       

        public Size GetSize()
        {
            if (!String.IsNullOrEmpty(_path))
                return GetImageSize(_path);

            return new Size(0, 0);
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
            return _position;
        }



        public void SetPosition(Point point)
        {
            _position = point;
        }

        public void DrawImage(Graphics g, MouseButtons button)
        {
            using (Image sourceImage = Image.FromFile(_path))
            {
                Rectangle rectangle = new Rectangle(GetPosition(), GetSize());
                g.DrawImage(sourceImage, rectangle);
            }
        }

        public void SetPath(string value)
        {
            _path = value;
        }

        public string GetPath()
        {
            return _path;
        }
    }
}
