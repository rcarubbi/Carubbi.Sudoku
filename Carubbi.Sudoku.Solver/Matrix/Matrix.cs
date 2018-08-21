using System;
using System.Collections.Generic;
using System.Drawing;

namespace Carubbi.Sudoku.Solver
{
    public class Matrix : IDisposable
    {
        private void LoadValueInColumn(Point coordinates, int value)
        {
            Columns[coordinates.Y - 1].Cells[coordinates.X - 1].Value = value;
        }

        private void LoadValueInRow(Point coordinates, int value)
        {
            Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value = value;
        }

        private void LoadValueInQuadrant(Point coordinates, int value)
        {
            Quadrants[CoordHelper.GetQuadrantNumber(coordinates) - 1].GetCellByCoordinates(coordinates).Value = value;
        }

        private void CreateQuadrants()
        {
            for (var quadrantIndex = 0; quadrantIndex < Quadrants.Capacity; quadrantIndex++)
                Quadrants.Add(new Section(SectionType.Quadrant, quadrantIndex + 1));
        }

        private void CreateRows()
        {
            for (var rowIndex = 0; rowIndex < Rows.Capacity; rowIndex++)
                Rows.Add(new Section(SectionType.Row, rowIndex + 1));
        }

        private void CreateColumns()
        {
            for (var columnIndex = 0; columnIndex < Columns.Capacity; columnIndex++)
                Columns.Add(new Section(SectionType.Column, columnIndex + 1));
        }

        public string Number { get; set; }

        public Matrix(Matrix matrixState) : this()
        {
            foreach (var row in matrixState.Rows)
            {
                foreach (var cell in row.Cells)
                    LoadValue(cell.Coordinates, cell.Value);
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
                foreach (var section in Rows)
                    section.Dispose();
            }
            if (Columns != null)
            {
                foreach (var section in Columns)
                    section.Dispose();
            }
            if (Quadrants != null)
            {
                foreach (var section in Quadrants)
                    section.Dispose();
            }
            Rows = null;
            Columns = null;
            Quadrants = null;
        }
    }
}
