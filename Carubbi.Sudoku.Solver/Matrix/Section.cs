using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Carubbi.Sudoku.Solver
{
    public class Section : IDisposable
    {
        public Section(SectionType type, int number)
        {
            Type = type;
            Number = number;
            Cells = new List<Cell>(9);
            CreateCells();
        }

        public Cell GetCellByCoordinates(Point coords)
        {
            foreach (Cell cell in Cells)
                if (cell.Coordinates.X == coords.X && cell.Coordinates.Y == coords.Y)
                    return cell;

            return null;
        }

        public int Number
        {
            get;
            set;
        }

        private void CreateCells()
        {
            switch (Type)
            {
                case SectionType.Row:
                    for (int cellIndex = 0; cellIndex < Cells.Capacity; cellIndex++)
                        Cells.Add(new Cell(new Point(Number, cellIndex+1)));
                    break;
                case SectionType.Column:
                    for (int cellIndex = 0; cellIndex < Cells.Capacity; cellIndex++)
                        Cells.Add(new Cell(new Point(cellIndex+1, Number)));
                    break;
                case SectionType.Quadrant:
                    int rowStart = CoordHelper.GetRowStartByQuadrant(Number);
                    int columnStart = CoordHelper.GetColumnStartByQuadrant(Number);
                    for (int rowIndex = rowStart; rowIndex <= rowStart + 2; rowIndex++)
                    {
                        for (int columnIndex = columnStart; columnIndex <= columnStart + 2; columnIndex++)
                            Cells.Add(new Cell(new Point(rowIndex, columnIndex)));
                    }
                    break;

            }
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
            foreach (Cell cell in Cells)
                cell.Dispose();

            Cells = null;

        }
    }
}
