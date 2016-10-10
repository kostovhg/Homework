using System;
using System.Linq;

namespace ex09_LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            // Define number of lines
            int lines = 2; // hardcoded to met exercises conditions
            int points = 2; // hardcoded to determine line
            //int dimensions = 2; // hardcoded for working in two dimentions
            double length = 0;
            int biggerLineIndex = 0;
            // collect user input for coordinates
            // Option 1. With three dimentional array -> columns X and Y,
            // rows are first and second point and 3-th dimention is for
            // different lines. Example: {{{x1, y1} {x2, y2}}{{x3, y3}{x4, y4}}}

            // Option 2. Every array, represents signle dot.

            // Option 1: 
            double[,,] inputCoord = GetLinesCoordinates(lines, points);
            for (int i = 0; i < lines; i++) // check each line
            {
                double tmpLength = length; // length for current itteration 
                // convert 3d array to 2d array for four coordinates = one line
                double[,] currentLine = GetEachLine(inputCoord, i); 
                // Compare length for current i (z - line)
                // if it is bigger than the previeus save index 'z' -> line number
                if (LineLength(currentLine) > tmpLength)
                {
                    biggerLineIndex = i;
                    length = LineLength(currentLine);
                }
                
            }

            // Rearange lineArray (bigger one) to start with point closer to zero
            double[,] biggerLine = RearangeCoordinates(GetEachLine(inputCoord, biggerLineIndex));

            PrintLineCoordinates(biggerLine);

        }

        private static double[,,] GetLinesCoordinates(int lines, int points)
        {
            double[,,] coordinates = new double[points, 2, lines];

            for (int z = 0; z < lines; z++)
            {
                for (int x = 0; x < 2; x++)
                {
                    for (int y = 0; y < points; y++)
                    {
                        coordinates[x, y, z] = double.Parse(Console.ReadLine());
                    }
                }
            }
            return coordinates;
        }

        private static double[,] RearangeCoordinates(double[,] linePoints)
        {
            double[,] arrangedLinePoints = new double[2, 2];
            double[] closerPoint = { linePoints[0, 0], linePoints[0, 1] };
            double[] awayPoint = { linePoints[1, 0], linePoints[1, 1] };

            if (!closerPoint.SequenceEqual(ClosestToCenter(linePoints)))
            {
                arrangedLinePoints[0, 0] = awayPoint[0];
                arrangedLinePoints[0, 1] = awayPoint[1];
                arrangedLinePoints[1, 0] = closerPoint[0];
                arrangedLinePoints[1, 1] = closerPoint[1];
            }
            else
            {
                Array.Copy(linePoints, 0, arrangedLinePoints, 0, linePoints.Length);
            }
            return arrangedLinePoints;
        }

        static double LineLength(double[,] linePoints)
        {
            double length = 0.0;
            double lineX = 0.0;
            double lineY = 0.0;
            lineX = Math.Max(linePoints[0, 0], linePoints[1, 0]) - Math.Min(linePoints[0, 0], linePoints[1, 0]);
            lineY = Math.Max(linePoints[0, 1], linePoints[1, 1]) - Math.Min(linePoints[0, 1], linePoints[1, 1]);
            length = Math.Sqrt(lineX * lineX + lineY * lineY);
            return length;
        }

        static double[] ClosestToCenter(double[,] pointsXY)
        {
            double[] pointXY = new double[2];
            double max = double.MaxValue;
            for (int i = 0; i < pointsXY.GetLength(0); i++)
            {
                double x = pointsXY[i, 0];
                double y = pointsXY[i, 1];

                if ((x * x + y * y) < max)
                {
                    pointXY[0] = x;
                    pointXY[1] = y;
                    max = (x * x + y * y);
                }

            }
            return pointXY;
        }

        static double[,] GetEachLine(double[,,] threeDim, int currentDim = 0)
        {
            double[,] twoDim = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    twoDim[i, j] = threeDim[i, j, currentDim];
                }
            }
            return twoDim;
        }

        static void PrintLineCoordinates(double[,] arrayToPrint)
        {
            for (int x = 0; x < 2; x++)
            {
                Console.Write("({0}, {1})", arrayToPrint[x, 0], arrayToPrint[x, 1]);
            }
            Console.WriteLine();
            
        }
    }
}
