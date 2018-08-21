using System;

namespace Carubbi.Sudoku.Solver
{
    public class ValueChangedEventArgs : EventArgs
    {
        public ValueChangedEventArgs(Matrix state)
        {
            State = state;
        }

        public Matrix State
        {
            get;
            set;
        }
    }
}
