using System.Collections.Generic;

namespace SudokuSolver
{
    class Backtrack
    {
        private Stack<Sudoku> fStack;

        public Backtrack(Sudoku lInitial)
        {
            fStack = new Stack<Sudoku>();
            fStack.Push(lInitial);
        }

        public Sudoku Solve()
        {
            do
            {
                Sudoku lSudoku = fStack.Pop();

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
                        fStack.Push(lMoveSudoku);
                    }
                }
            } while (fStack.Count > 0);

            return null;
        }
    }
}
