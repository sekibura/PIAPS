using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Proxy
{
    class Position
    {
        private int _x, _y;
        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }



        public int GetX() => _x;
        public int GetY() => _y;






    }
}
