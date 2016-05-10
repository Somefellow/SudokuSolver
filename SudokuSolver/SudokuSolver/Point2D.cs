using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    struct Point2D
    {
        private int fX;
        private int fY;

        public Point2D(int aIndex)
        {
            fX = aIndex % 9;
            fY = aIndex / 9;
        }

        public Point2D(int aX, int aY)
        {
            fX = aX;
            fY = aY;
        }

        public int X
        {
            get
            {
                return fX;
            }

            set
            {
                fX = value;
            }
        }

        public int Y
        {
            get
            {
                return fY;
            }

            set
            {
                fY = value;
            }
        }
    }
}
