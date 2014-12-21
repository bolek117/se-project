using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Classes.Common
{
    class XYPair
    {
        private int _x;
        private int _y;

        int GetX()
        {
            return _x;
        }

        bool SetX(int x)
        {
            _x = x;
            return _x == x;
        }

        int GetY()
        {
            return _y;
        }

        bool SetY(int y)
        {
            _y = y;
            return _y == y;
        }

        bool SetXY(int x, int y)
        {
            _x = x;
            _y = y;
            return (_x == x && _y == y);
        }
    }
}
