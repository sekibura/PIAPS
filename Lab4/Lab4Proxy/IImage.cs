using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab4Proxy
{
    interface IImage
    {
        public Point GetPosition();

        public void SetPosition(Point point);

        public Size GetSize();

        public string Path { get; set; }

        public void DrawImage(Graphics g, MouseButtons button);

    }
}
