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
