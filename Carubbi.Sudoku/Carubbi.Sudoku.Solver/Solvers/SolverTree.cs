using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carubbi.Sudoku.Solver
{
    public class SolverTree
    {
        public SolverTree(Matrix mainMatrix)
        {
            Root = new SolverNode(mainMatrix);
        }

        public SolverNode Root
        {
            get;
            set;
        }

    }
}
