#define EASY

using System;
using System.Diagnostics;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
#if EASY
            string lString = 
                "003020600" +
                "900305001" +
                "001806400" +
                "008102900" +
                "700000008" +
                "006708200" +
                "002609500" +
                "800203009" +
                "005010300";
#elif HARD
            string lString =
                "800000000" +
                "003600000" +
                "070090200" +
                "050007000" +
                "000045700" +
                "000100030" +
                "001000068" +
                "008500010" +
                "090000400";
#elif BLANK
            string lString = string.Empty;
            for (int i = 0; i < 81; i++)
                lString += '0';
#endif

            Sudoku lInitial = new Sudoku(lString);
            Backtrack lBT = new Backtrack(lInitial);

            lInitial.Draw();
            Console.WriteLine();

            Stopwatch Timer = Stopwatch.StartNew();
            Sudoku lSudoku = lBT.Solve();
            Timer.Stop();

            if (lSudoku == null)
            {
                Console.WriteLine("Did not find a solution...");
            }
            else
            {
                lSudoku.Draw();
            }

            Console.WriteLine("\nTime taken - {0}ms", Timer.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
