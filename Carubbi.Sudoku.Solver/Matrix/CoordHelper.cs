using System.Drawing;

namespace Carubbi.Sudoku.Solver
{
    public static class CoordHelper
    {

        public static int GetQuadrantNumber(Point coordinates)
        {
            switch (coordinates.X)
            {
                case 1:
                case 2:
                case 3:
                    switch (coordinates.Y)
                    { 
                        case 1:
                        case 2:
                        case 3:
                            return 1;
                        case 4:
                        case 5:
                        case 6:
                            return 2;
                        case 7:
                        case 8:
                        case 9:
                            return 3;
                        default:
                            return 0;
                    }
                case 4:
                case 5:
                case 6:
                    switch (coordinates.Y)
                    {
                        case 1:
                        case 2:
                        case 3:
                            return 4;
                        case 4:
                        case 5:
                        case 6:
                            return 5;
                        case 7:
                        case 8:
                        case 9:
                            return 6;
                        default:
                            return 0;
                    }
                    
                case 7:
                case 8:
                case 9:
                    switch (coordinates.Y)
                    {
                        case 1:
                        case 2:
                        case 3:
                            return 7;
                        case 4:
                        case 5:
                        case 6:
                            return 8;
                        case 7:
                        case 8:
                        case 9:
                            return 9;
                        default:
                            return 0;
                    }
                default:
                    return 0;
            }
        }


        public static int GetRowStartByQuadrant(int quadrantNumber)
        {

            switch (quadrantNumber)
            {
                case 1:
                case 2:
                case 3:
                    return 1;
                case 4:
                case 5:
                case 6:
                    return 4;
                case 7:
                case 8:
                case 9:
                    return 7;
                default:
                    return 0;
            }

        }

        public static int GetColumnStartByQuadrant(int quadrantNumber)
        {
            switch (quadrantNumber)
            {
                case 1:
                case 4:
                case 7:
                    return 1;
                case 2:
                case 5:
                case 8:
                    return 4;
                case 3:
                case 6:
                case 9:
                    return 7;
                default:
                    return 0;
            }  
        
        }
    }
}
