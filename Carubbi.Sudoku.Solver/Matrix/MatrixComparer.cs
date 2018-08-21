using System;
using System.Collections.Generic;

namespace Carubbi.Sudoku.Solver
{
    public class MatrixComparer : IEqualityComparer<Matrix>
    {
        public bool Equals(Matrix x, Matrix y)
        {
            foreach (var row in x.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    if (cell.Value != y.Rows[cell.Coordinates.X - 1].Cells[cell.Coordinates.Y - 1].Value)
                        return false;
                }

            }
            return true;
        }

        public int GetHashCode(Matrix obj)
        {
            throw new NotImplementedException();
        }
    }
}
