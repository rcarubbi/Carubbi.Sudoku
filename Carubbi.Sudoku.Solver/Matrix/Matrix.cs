using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Carubbi.Sudoku.Solver
{
    public class MatrixComparer : IEqualityComparer<Matrix>
    {

        public bool Equals(Matrix x, Matrix y)
        {
            foreach (Section row in x.Rows)
            {
                foreach (Cell cell in row.Cells)
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

    public class Matrix : IDisposable
    {

        public string Number { get; set; }

        public Matrix(Matrix matrixState) : this()
        {
            foreach (Section row in matrixState.Rows)
            {
                foreach (Cell cell in row.Cells)
                    this.LoadValue(cell.Coordinates, cell.Value);
            }
        }

        public static MatrixComparer Comparer = new MatrixComparer();

        public Matrix()
        {
            Quadrants = new List<Section>(9);
            Rows = new List<Section>(9);
            Columns = new List<Section>(9);

            CreateQuadrants();
            CreateRows();
            CreateColumns();

            HasSolution = true;
        }

        public void LoadValue(Point coordinates, int value)
        {
            LoadValueInColumn(coordinates, value);
            LoadValueInRow(coordinates, value);
            LoadValueInQuadrant(coordinates, value);
        }

        private void LoadValueInColumn(Point coordinates, int value)
        {
            this.Columns[coordinates.Y - 1].Cells[coordinates.X - 1].Value = value;
        }

        private void LoadValueInRow(Point coordinates, int value)
        {
            this.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value = value;
        }

        private void LoadValueInQuadrant(Point coordinates, int value)
        {
            this.Quadrants[CoordHelper.GetQuadrantNumber(coordinates) - 1].GetCellByCoordinates(coordinates).Value = value; 
        }


        public bool HasSolution
        {
            get;
            set;
        }

        public bool IsResolved
        {
            get;
            set;
        }

        private void CreateQuadrants()
        {
            for (int quadrantIndex = 0; quadrantIndex < Quadrants.Capacity; quadrantIndex++)
                Quadrants.Add(new Section(SectionType.Quadrant, quadrantIndex + 1));
        }

        private void CreateRows()
        {
            for (int rowIndex = 0; rowIndex < Rows.Capacity; rowIndex++)
                Rows.Add(new Section(SectionType.Row, rowIndex + 1));
        }

        private void CreateColumns()
        {
            for (int columnIndex = 0; columnIndex < Columns.Capacity; columnIndex++)
                Columns.Add(new Section(SectionType.Column, columnIndex + 1));
        }

        public List<Section> Quadrants
        {
            get;
            set;
        }

        public List<Section> Rows
        {
            get;
            set;
        }

        public List<Section> Columns
        {
            get;
            set;
        }



        public void Dispose()
        {
            if (Rows != null)
            {
                foreach (Section section in Rows)
                    section.Dispose();
            }
            if (Columns != null)
            {
                foreach (Section section in Columns)
                    section.Dispose();
            }
            if (Quadrants != null)
            {
                foreach (Section section in Quadrants)
                    section.Dispose();
            }
            Rows = null;
            Columns = null;
            Quadrants = null;
        }
    }
}
