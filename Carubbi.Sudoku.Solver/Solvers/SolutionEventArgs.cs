using System;

namespace Carubbi.Sudoku.Solver
{
    public class SolutionEventArgs : EventArgs
    {
        public Matrix Solution
        {
            get;
            set;
        }
    }
}
