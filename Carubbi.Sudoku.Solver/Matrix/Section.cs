using System;
using System.Collections.Generic;
using System.Drawing;

namespace Carubbi.Sudoku.Solver
{
    public class Section : IDisposable
    {
        private void CreateCells()
        {
            switch (Type)
            {
                case SectionType.Row:
                    for (var cellIndex = 0; cellIndex < Cells.Capacity; cellIndex++)
                        Cells.Add(new Cell(new Point(Number, cellIndex + 1)));
                    break;
                case SectionType.Column:
                    for (var cellIndex = 0; cellIndex < Cells.Capacity; cellIndex++)
                        Cells.Add(new Cell(new Point(cellIndex + 1, Number)));
                    break;
                case SectionType.Quadrant:
                    var rowStart = CoordHelper.GetRowStartByQuadrant(Number);
                    var columnStart = CoordHelper.GetColumnStartByQuadrant(Number);
                    for (var rowIndex = rowStart; rowIndex <= rowStart + 2; rowIndex++)
                    {
                        for (var columnIndex = columnStart; columnIndex <= columnStart + 2; columnIndex++)
                            Cells.Add(new Cell(new Point(rowIndex, columnIndex)));
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Section(SectionType type, int number)
        {
            Type = type;
            Number = number;
            Cells = new List<Cell>(9);
            CreateCells();
        }

        public Cell GetCellByCoordinates(Point coords)
        {
            foreach (var cell in Cells)
                if (cell.Coordinates.X == coords.X && cell.Coordinates.Y == coords.Y)
                    return cell;

            return null;
        }

        public int Number
        {
            get;
            set;
        }

        public SectionType Type
        {
            get;
            set;
        }

        public List<Cell> Cells
        {
            get;
            set;
        }

        public void Dispose()
        {
            foreach (var cell in Cells)
                cell.Dispose();

            Cells = null;

        }
    }
}
