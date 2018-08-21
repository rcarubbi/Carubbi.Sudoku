using System;
using System.Collections.Generic;

namespace Carubbi.Sudoku.Solver
{
    public class SolverNode : IDisposable
    {
        public SolverNode(Matrix matrix)
        {
            MatrixState = matrix;
            ChildNodes = new List<SolverNode>();
        }

        public List<SolverNode> ChildNodes
        {
            get;
            set;
        }
        
        public Matrix MatrixState
        {
            get;
            set;
        }

        public void Dispose()
        {
            MatrixState.Dispose();
            foreach (var node in ChildNodes)
                node.Dispose();
        }
    }
}
