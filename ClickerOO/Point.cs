using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerOO
{
    class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Flip()
        {
            int tmp = _x;
            _x = _y;
            _y = tmp;
        }
    }
}
