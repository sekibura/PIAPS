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
        public string Path { get; set; }
       

        public Size GetSize()
        {
            if (!String.IsNullOrEmpty(Path))
                return GetImageSize(Path);

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
            throw new NotImplementedException();
        }



        public void SetPosition(Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawImage(Graphics g, MouseButtons button)
        {
            using (Image sourceImage = Image.FromFile(Path))
            {
                Rectangle rectangle = new Rectangle(GetPosition(), GetSize());
                g.DrawImage(sourceImage, rectangle);
            }
        }

  
    }
}
