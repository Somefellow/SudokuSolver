using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            string lInput =
                "020178030" +
                "040302090" +
                "100000006" +
                "008603500" +
                "300000004" +
                "006709200" +
                "900000002" +
                "080901060" +
                "010436050";

            Backtrack lBT = new Backtrack(new Sudoku(lInput));
            new Sudoku(lInput).Draw();
            Sudoku lSudoku = lBT.Solve();
            if (lSudoku == null)
            {
                Console.WriteLine("Did not find a solution...");
            }
            else
            {
                lSudoku.Draw();
            }
            Console.ReadKey();
        }
    }
}
