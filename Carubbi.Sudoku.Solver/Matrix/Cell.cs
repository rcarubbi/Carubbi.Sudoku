using System;
using System.Collections.Generic;
using System.Drawing;

namespace Carubbi.Sudoku.Solver
{
    public class Cell : IDisposable
    {
        public Cell(Point coordinates)
        {
            Possibilities = new List<int>();
            Coordinates = coordinates;
        }

        public Point Coordinates
        {
            get;
            set;
        }

        public List<int> Possibilities
        {
            get;
            set;
        }

        public int Value
        {
            get;
            set;
        }


        public void Dispose()
        {
            Possibilities = null;
        }
    }
}
