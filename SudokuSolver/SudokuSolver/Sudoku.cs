using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Sudoku // Only normal size.
    {
        private int[] fGrid;

        public Sudoku(string lString)
        {
            fGrid = new int[lString.Length];
            
            for (int i = 0; i < lString.Length; i++)
            {
                fGrid[i] = lString[i] - '0';
            }
        }

        public Sudoku(Sudoku aSudoku)
        {
            fGrid = aSudoku.fGrid.Clone() as int[];
        }

        public void Draw()
        {
            for (int i = 0; i < fGrid.Length; i++)
            {
                if (fGrid[i] == 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write(fGrid[i]);
                }

                if ((i + 1) % 9 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        //public int ValueAt(Point2D aPoint)
        //{
        //    return fGrid[(aPoint.Y * 9) + aPoint.X];
        //}

        public int ValueAt(int aIndex)
        {
            return fGrid[aIndex];
        }

        public void SetValue(int aIndex, int aValue)
        {
            Console.WriteLine("Writing in {0} at {1}", aValue, aIndex);
            fGrid[aIndex] = aValue;
        }

        //public void SetValue(Point2D aPoint, int aValue)
        //{
        //    fGrid[(aPoint.Y * 9) + aPoint.X] = aValue;
        //}

        public bool CanSetValue(int aIndex, int aValue)
        {
            Point2D lPoint = new Point2D(aIndex);

            if (!CheckRow(lPoint, aValue)) return false;
            if (!CheckColumn(lPoint, aValue)) return false;
            if (!CheckSubGrid(lPoint, aValue)) return false;

            return true;
        }

        //public bool CanSetValue(Point2D aPoint, int Value)
        //{
        //    if (!CheckRow(aPoint, Value)) return false;
        //    if (!CheckColumn(aPoint, Value)) return false;
        //    if (!CheckSubGrid(aPoint, Value)) return false;
        //
        //    return true;
        //}

        public bool Solved()
        {
            return !fGrid.Contains(0);
        }

        public bool CheckRow(Point2D aPoint, int aValue)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != aPoint.X && fGrid[(aPoint.Y * 9) + i] == aValue) return false;
            }

            return true;
        }

        private bool CheckColumn(Point2D aPoint, int aValue)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != aPoint.Y && fGrid[(i * 9) + aPoint.X] == aValue) return false;
            }

            return true;
        }

        public bool CheckSubGrid(Point2D aPoint, int aValue)
        {
            Point2D lUpperLeft = new Point2D((int)Math.Floor((double)aPoint.X / 3) * 3, (int)Math.Floor((double)aPoint.Y / 3) * 3);

            for (int lX = 0; lX < 3; lX++)
            {
                for (int lY = 0; lY < 3; lY++)
                {
                    if (!(lX == aPoint.X && lY == aPoint.Y) && fGrid[(lY * 9) + lX] == aValue) return false;
                }
            }

            return true;
        }

        //public bool CheckRow(Point2D aPoint, int aValue)
        //{
        //    for (int i = 0; i < 9; i++)
        //    {
        //        if (i != aPoint.X && fGrid[(aPoint.Y * 9) + i] == aValue) return false;
        //    }
        //
        //    return true;
        //}
        //
        //private bool CheckColumn(Point2D aPoint, int aValue)
        //{
        //    for (int i = 0; i < 9; i++)
        //    {
        //        if (i != aPoint.Y && fGrid[(i * 9) + aPoint.X] == aValue) return false;
        //    }
        //
        //    return true;
        //}
        //
        //public bool CheckSubGrid(Point2D aPoint, int aValue)
        //{
        //    Point2D lUpperLeft = new Point2D((int)Math.Floor((double)aPoint.X / 3) * 3, (int)Math.Floor((double)aPoint.Y / 3) * 3);
        //
        //    for (int lX = 0; lX < 3; lX++)
        //    {
        //        for (int lY = 0; lY < 3; lY++)
        //        {
        //            if (!(lX == aPoint.X && lY == aPoint.Y) && fGrid[(lY * 9) + lX] == aValue) return false;
        //        }
        //    }
        //
        //    return true;
        //}
    }
}
