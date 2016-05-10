using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Backtrack
    {
        private Queue<Sudoku> fQueue;

        public Backtrack(Sudoku lInitial)
        {
            fQueue = new Queue<Sudoku>();
            fQueue.Enqueue(lInitial);
        }

        public Sudoku Solve()
        {
            do
            {
                Sudoku lSudoku = fQueue.Dequeue();

                if (lSudoku.Solved())
                {
                    return lSudoku;
                }

                int lBlankIndex;

                for (lBlankIndex = 0; lBlankIndex < 81; lBlankIndex++)
                {
                    if (lSudoku.ValueAt(lBlankIndex) == 0)
                    {
                        break;
                    }
                }

                for (int i = 9; i > 0; i--)
                {
                    if (lSudoku.CanSetValue(lBlankIndex, i))
                    {
                        Sudoku lMoveSudoku = new Sudoku(lSudoku);
                        lMoveSudoku.SetValue(lBlankIndex, i);
                        fQueue.Enqueue(lMoveSudoku);
                    }
                }
            } while (fQueue.Count > 0);

            return null;
        }
    }
}
