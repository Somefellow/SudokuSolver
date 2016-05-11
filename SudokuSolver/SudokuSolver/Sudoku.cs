using System;
using System.Linq;

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

        public int ValueAt(int aIndex)
        {
            return fGrid[aIndex];
        }

        public void SetValue(int aIndex, int aValue)
        {
            fGrid[aIndex] = aValue;
        }

        public bool CanSetValue(int aIndex, int aValue)
        {
            if (!CheckRow(aIndex, aValue)) return false;
            else if (!CheckColumn(aIndex, aValue)) return false;
            else if (!CheckSubGrid(aIndex, aValue)) return false;
            else return true;
        }

        public bool Solved()
        {
            return !fGrid.Contains(0);
        }

        public bool CheckRow(int aIndex, int aValue)
        {
            int lOffset = aIndex / 9 * 9;
            
            for (int i = lOffset; i < (9 + lOffset); i++)
            {
                if (i != aIndex && fGrid[i] == aValue) return false;
            }

            return true;
        }

        public bool CheckColumn(int aIndex, int aValue)
        {
            for (int i = (aIndex % 9); i < 81; i += 9)
            {
                if (i != aIndex && fGrid[i] == aValue) return false;
            }

            return true;
        }

        public bool CheckSubGrid(int aIndex, int aValue)
        {
            int lXValue = aIndex % 9;
            int lYValue = aIndex / 9;

            int lXStart = lXValue - (lXValue % 3);
            int lYStart = lYValue - (lYValue % 3);

            for (int lX = lXStart; lX < (3 + lXStart); lX++)
            {
                for (int lY = lYStart; lY < (3 + lYStart); lY++)
                {
                    int lIndex = (lY * 9) + lX;

                    if (lIndex != aIndex && fGrid[lIndex] == aValue) return false;
                }
            }

            return true;
        }
    }
}
