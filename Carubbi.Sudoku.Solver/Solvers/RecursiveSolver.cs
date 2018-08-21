using System;
using System.Collections.Generic;
using System.Linq;

namespace Carubbi.Sudoku.Solver
{
    public class RecursiveSolver
    {
        public event EventHandler<ValueChangedEventArgs> ValueAdded;
        public event EventHandler<ValueChangedEventArgs> ValueRemoved;
        public event EventHandler<SolutionEventArgs> SolutionFound;

        public RecursiveSolver(Matrix mainMatrix)
        {
            _tree = new SolverTree(mainMatrix);
        }

        private readonly SolverTree _tree;

        public List<Matrix> Solve(int numberOfSolutions)
        {
            var solutions = new List<Matrix>(numberOfSolutions);
            RecursiveSolve(_tree.Root, solutions);
            return solutions;
        }

        private void RecursiveSolve(SolverNode node, List<Matrix> solutions)
        {
            var emptyCells = ListEmptyCells(node.MatrixState);

            if (node.MatrixState.HasSolution && !node.MatrixState.IsResolved)
            {
                foreach (var emptyCell in emptyCells)
                {
                    CalculatePossibilities(emptyCell, node.MatrixState);
                    if (emptyCell.Possibilities.Count != 1) continue;

                    var foundedValue = emptyCell.Possibilities[0];
                    emptyCell.Value = foundedValue;
                    node.MatrixState.LoadValue(emptyCell.Coordinates, emptyCell.Value);

                    ValueAdded?.Invoke(this, new ValueChangedEventArgs(node.MatrixState));

                    RecursiveSolve(node, solutions);

                    if (solutions.Count == solutions.Capacity) break;

                    if (node.MatrixState.HasSolution) continue;

                    node.Dispose();
                    node = null;
                    break;

                }
            }

            if (node != null && (emptyCells.Count == 0 && !node.MatrixState.IsResolved))
            {
                node.MatrixState.IsResolved = true;

                if (solutions.Contains(node.MatrixState, Matrix.Comparer) ||
                    solutions.Count >= solutions.Capacity) return;

                solutions.Add(node.MatrixState);

                SolutionFound?.Invoke(this, new SolutionEventArgs { Solution = node.MatrixState });
            }
            else
            {
                if (node == null || node.ChildNodes.Count != 0 || node.MatrixState.IsResolved ||
                    !node.MatrixState.HasSolution) return;

                var orderedEmptyCells = (from emptyCell in emptyCells orderby emptyCell.Possibilities.Count select emptyCell).ToList();

                if (orderedEmptyCells.Count > 0)
                {
                    var lessPossibilitiesCell = orderedEmptyCells[0];

                    if (lessPossibilitiesCell.Possibilities.Count > 0)
                    {
                        foreach (var possibility in lessPossibilitiesCell.Possibilities)
                        {
                            var possibleState = new Matrix(node.MatrixState);
                            possibleState.LoadValue(lessPossibilitiesCell.Coordinates, possibility);

                            ValueAdded?.Invoke(this, new ValueChangedEventArgs(possibleState));

                            node.ChildNodes.Add(new SolverNode(possibleState));
                        }

                        var noSolutionCount = 0;

                        foreach (var childNode in node.ChildNodes)
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

                        if (node != null && (node.ChildNodes.Count <= 0 || node.ChildNodes.Count != noSolutionCount ||
                                             node.MatrixState.IsResolved)) return;

                        node.MatrixState.HasSolution = false;

                        ValueRemoved?.Invoke(this, new ValueChangedEventArgs(node.MatrixState));
                    }
                    else
                    {
                        node.MatrixState.HasSolution = false;

                        ValueRemoved?.Invoke(this, new ValueChangedEventArgs(node.MatrixState));
                    }
                }
                else
                {
                    node.MatrixState.HasSolution = false;

                    ValueRemoved?.Invoke(this, new ValueChangedEventArgs(node.MatrixState));
                }
            }

        }

        private static void CalculatePossibilities(Cell cell, Matrix matrix)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var columConstraints = (from columnCell in matrix.Columns[cell.Coordinates.Y-1].Cells
                                           where cell.Coordinates.X != columnCell.Coordinates.X && columnCell.Value > 0
                                           select columnCell.Value).ToList();

            var rowConstraints = (from rowCell in matrix.Rows[cell.Coordinates.X - 1].Cells
                                   where cell.Coordinates.Y != rowCell.Coordinates.Y && rowCell.Value > 0
                                   select rowCell.Value).ToList();

            var quadrantConstraints = (from quadrantCell in matrix.Quadrants[CoordHelper.GetQuadrantNumber(cell.Coordinates) - 1].Cells
                                               where (cell.Coordinates.X != quadrantCell.Coordinates.X ||
                                                     cell.Coordinates.Y != quadrantCell.Coordinates.Y) 
                                                     && quadrantCell.Value > 0
                                               select quadrantCell.Value).ToList();

            var constraints = new List<int>();
            constraints.AddRange(columConstraints);
            constraints.AddRange(rowConstraints);
            constraints.AddRange(quadrantConstraints);

            var possibilities = (from number in numbers
                                where !constraints.ToList().Contains(number)
                                select number).ToList();

            cell.Possibilities = possibilities;

        }

        private static List<Cell> ListEmptyCells(Matrix matrix)
        {
            var emptyCells = from row in matrix.Rows
                             from cell in row.Cells
                             where cell.Value == 0
                             select cell;
        
            return emptyCells.ToList();
        }

    }
}
