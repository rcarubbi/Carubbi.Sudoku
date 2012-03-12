using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

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

    public class SolutionEventArgs : EventArgs
    {
        public Matrix Solution
        {
            get;
            set;
        }
    }

    public class RecursiveSolver
    {

        public event EventHandler<ValueChangedEventArgs> ValueAdded;
        public event EventHandler<ValueChangedEventArgs> ValueRemoved;
        public event EventHandler<SolutionEventArgs> SolutionFound;


        public RecursiveSolver(Matrix mainMatrix)
        {
            _tree = new SolverTree(mainMatrix);
        }

        private SolverTree _tree;

        public List<Matrix> Solve(int numberOfSolutions)
        {
            List<Matrix> solutions = new List<Matrix>(numberOfSolutions);
            RecursiveSolve(_tree.Root, solutions);
            return solutions;
        }

       

        private void RecursiveSolve(SolverNode node, List<Matrix> solutions)
        {
            List<Cell> emptyCells = ListEmptyCells(node.MatrixState);

            if (node.MatrixState.HasSolution && !node.MatrixState.IsResolved)
            {
                foreach (Cell emptyCell in emptyCells)
                {
                    CalculatePossibilities(emptyCell, node.MatrixState);
                    if (emptyCell.Possibilities.Count == 1)
                    {
                        int foundedValue = emptyCell.Possibilities[0];
                        emptyCell.Value = foundedValue;
                        node.MatrixState.LoadValue(emptyCell.Coordinates, emptyCell.Value);
                        if (ValueAdded != null)
                            ValueAdded(this, new ValueChangedEventArgs(node.MatrixState));
                        RecursiveSolve(node, solutions);
                        if (solutions.Count == solutions.Capacity)
                            break;
                        if (!node.MatrixState.HasSolution)
                        {
                            node.Dispose();
                            node = null;
                            break;
                        }
                    }

                }
            }

            if (emptyCells.Count == 0 && !node.MatrixState.IsResolved)
            {
                node.MatrixState.IsResolved = true;
                if (!solutions.Contains(node.MatrixState, Matrix.Comparer) && solutions.Count < solutions.Capacity)
                {
                    solutions.Add(node.MatrixState);
                    if (SolutionFound != null)
                        SolutionFound(this, new SolutionEventArgs() { Solution = node.MatrixState });
                }
            }
            else
            {
                
                if (node != null && node.ChildNodes.Count == 0 && !node.MatrixState.IsResolved && node.MatrixState.HasSolution)
                {
                    
                    
                    List<Cell> orderedEmptyCells = (from emptyCell in emptyCells orderby emptyCell.Possibilities.Count select emptyCell).ToList();
                    if (orderedEmptyCells.Count > 0)
                    {
                        
                        Cell lessPossibilitiesCell = orderedEmptyCells[0];
                        if (lessPossibilitiesCell.Possibilities.Count > 0)
                        {
                            foreach (int possibility in lessPossibilitiesCell.Possibilities)
                            {
                                Matrix possibleState = new Matrix(node.MatrixState);
                                possibleState.LoadValue(lessPossibilitiesCell.Coordinates, possibility);

                                if (ValueAdded != null)
                                    ValueAdded(this, new ValueChangedEventArgs(possibleState));
                                node.ChildNodes.Add(new SolverNode(possibleState));

                            }
                            int noSolutionCount = 0;
                            foreach (SolverNode childNode in node.ChildNodes)
                            {
                                RecursiveSolve(childNode, solutions);

                                if (solutions.Count == solutions.Capacity)
                                    break;
                                if (!node.MatrixState.HasSolution)
                                {
                                    node.Dispose();
                                    node = null;
                                    break;
                                }
                                if (!childNode.MatrixState.HasSolution)
                                {
                                    noSolutionCount++;
                                }
                            }
                            if (node.ChildNodes.Count > 0 && node.ChildNodes.Count == noSolutionCount && !node.MatrixState.IsResolved)
                            {
                                node.MatrixState.HasSolution = false;
                                if (ValueRemoved != null)
                                    ValueRemoved(this, new ValueChangedEventArgs(node.MatrixState));
                 
                            }
                        }
                        else
                        {
                            node.MatrixState.HasSolution = false;
                            if (ValueRemoved != null)
                                ValueRemoved(this, new ValueChangedEventArgs(node.MatrixState));
                 
                        }
                    }
                    else
                    {
                        node.MatrixState.HasSolution = false;
                        if (ValueRemoved != null)
                            ValueRemoved(this, new ValueChangedEventArgs(node.MatrixState));
                    }
                }
            }

        }

        private void CalculatePossibilities(Cell cell, Matrix matrix)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> columConstraints = (from columnCell in matrix.Columns[cell.Coordinates.Y-1].Cells
                                           where cell.Coordinates.X != columnCell.Coordinates.X && columnCell.Value > 0
                                           select columnCell.Value).ToList();

            List<int> rowConstraints = (from rowCell in matrix.Rows[cell.Coordinates.X - 1].Cells
                                   where cell.Coordinates.Y != rowCell.Coordinates.Y && rowCell.Value > 0
                                   select rowCell.Value).ToList();

            List<int> quadrantConstraints = (from quadrantCell in matrix.Quadrants[CoordHelper.GetQuadrantNumber(cell.Coordinates) - 1].Cells
                                               where (cell.Coordinates.X != quadrantCell.Coordinates.X ||
                                                     cell.Coordinates.Y != quadrantCell.Coordinates.Y) 
                                                     && quadrantCell.Value > 0
                                               select quadrantCell.Value).ToList();

            List<int> constraints = new List<int>();
            constraints.AddRange(columConstraints);
            constraints.AddRange(rowConstraints);
            constraints.AddRange(quadrantConstraints);

            List<int> possibilities = (from number in numbers
                                where !constraints.ToList().Contains(number)
                                select number).ToList();

            cell.Possibilities = possibilities;

        }

        private List<Cell> ListEmptyCells(Matrix matrix)
        {
            var emptyCells = from row in matrix.Rows
                             from cell in row.Cells
                             where cell.Value == 0
                             select cell;
        
            return emptyCells.ToList();
        }

    }
}
