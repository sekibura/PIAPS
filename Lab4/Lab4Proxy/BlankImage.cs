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
        private string _path;
        private Point position = new Point();
        private RealImage _realImage;
        private bool _havePicture;

        public BlankImage(RealImage realImage)
        {
            _realImage = realImage;
        }

        public void SetPath(string value)
        {
            _path = value;
            _realImage.SetPath(value);
        }

        public string GetPath()
        {
            return _path;
        }

        public Size GetSize()
        {
            if (!String.IsNullOrEmpty(_path))
                return GetImageSize(_path);
            
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
                _havePicture = true;
            }
        }

        public bool IsHavePucture()
        {
            return _havePicture;
        }
    }
}
