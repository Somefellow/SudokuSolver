using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Sudoku
    {
        private int fCellSize;
        private int[] fGrid;

        public Sudoku(int aCellSize, Dictionary<Point2D, int> aDictionary)
        {
            fCellSize = aCellSize;
            fGrid = new int[16];

            for (int i = 0; i < fGrid.Length; i++)
            {
                fGrid[i] = 0;
            }

            foreach (var lValue in aDictionary)
            {
                SetValue(lValue.Key, lValue.Value);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < fGrid.Length; i++)
            {
                if (fGrid[i] == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(fGrid[i]);
                }

                if (i % Math.Pow(fCellSize, fCellSize) == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        public int ValueAt(Point2D aPoint)
        {
            return fGrid[(aPoint.Y * fCellSize) + aPoint.X];
        }

        public bool SetValue(Point2D aPoint, int aValue)
        {
            fGrid[(aPoint.Y * fCellSize) + aPoint.X] = aValue;

            return true;

            throw new NotImplementedException();
        }

        public bool CheckSubGrid(Point2D aPoint, int aValue)
        {
            throw new NotImplementedException();


        }
    }
}
