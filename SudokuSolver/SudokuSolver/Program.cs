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
            var lDictionary = new Dictionary<Point2D, int>();
            lDictionary.Add(new Point2D(0, 0), 3);
            lDictionary.Add(new Point2D(1, 0), 4);
            lDictionary.Add(new Point2D(1, 1), 1);
            lDictionary.Add(new Point2D(3, 1), 3);
            lDictionary.Add(new Point2D(0, 2), 1);
            lDictionary.Add(new Point2D(2, 2), 2);
            lDictionary.Add(new Point2D(3, 3), 1);

            Sudoku lSudoku = new Sudoku(2, lDictionary);
            lSudoku.Draw();
            Console.ReadKey();
        }
    }
}
