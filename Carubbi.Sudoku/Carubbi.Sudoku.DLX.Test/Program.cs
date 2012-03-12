using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Specialized;

namespace Carubbi.Sudoku.DLX.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim = 9;
            Console.WriteLine("Starting: ");

            // example on how to solve a sudoku
            FileStream fs = new FileStream(@"sudoku.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            StringCollection sc = new StringCollection();
            string s = string.Empty;
            while ((s = sr.ReadLine()) != null)
            {
                if (s.Trim() != string.Empty)
                {
                    sc.Add(s.Trim());
                }
            }
            sr.Close();
            fs.Close();

            // got the strings
            SudokuSolveDLX sdlx = new SudokuSolveDLX(dim);
            sdlx.BuildSudokuMatrix();


            for (int i = 0; i < sc.Count / 9; i++)
            {
                string[] g = new string[9];
                for (int j = 0; j < 9; j++)
                {
                    g[j] = sc[j + 9 * i];
                }

                Console.WriteLine("Solving sudoku # " + i + "\n");
                Console.WriteLine("Original grid ");
                for (int k = 0; k < g.Length; k++)
                {
                    Console.WriteLine(g[k]);
                }
                Console.WriteLine("\nSolved grid: ");

                sdlx.SetStartingGrid(g);
                sdlx.SolveSudoku(SolveMethod.PrintSolutions);
                //sdlx.UnselectAllRows();

                Console.WriteLine();
            }


            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
