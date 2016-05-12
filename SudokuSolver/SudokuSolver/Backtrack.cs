using System.Collections.Generic;

namespace SudokuSolver
{
    class Backtrack
    {
        private Stack<Sudoku> fStack;
        private int fCheckCount;

        public Backtrack(Sudoku lInitial)
        {
            fStack = new Stack<Sudoku>();
            fStack.Push(lInitial);
            fCheckCount = 0;
        }

        public int CheckCount
        {
            get { return fCheckCount; }
        }

        public Sudoku Solve()
        {
            while (fStack.Count > 0)
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

                fCheckCount++;
            }

            return null;
        }
    }
}
