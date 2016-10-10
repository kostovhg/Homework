using System;

namespace ex08_CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            int points = 2;
            double[,] coordinates = new double[points, 2];
            for (int x= 0; x < points; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    coordinates[x, y] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine('(' + 
                String.Join(", ", ClosestToCenter(coordinates)) + 
                ')');
            
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
    }
}
