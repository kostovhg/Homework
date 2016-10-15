using System;
using System.Linq;

namespace ex05_ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            Point[] pointsToPrint = FindClosestPoints(points);

            PrintDistance(pointsToPrint);
            PrintPoint(pointsToPrint[0]);
            PrintPoint(pointsToPrint[1]);
        }

        private static Point[] FindClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] pointsToPrint = new Point[2];
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double dist = CalcDistance(points[i], points[j]);
                    if (minDistance > dist)
                    {
                        minDistance = dist;
                        pointsToPrint[0] = points[i];
                        pointsToPrint[1] = points[j];
                    }
                }
            }
            return pointsToPrint;
        }

        private static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }

        static double CalcDistance(Point point1, Point point2)
        {
            double distance = 0.0d;

            int x = point1.X - point2.X;
            int y = point1.Y - point2.Y;

            distance = Math.Sqrt(x * x + y * y);
            return distance;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static void PrintDistance(Point[] points)
        {
            Console.WriteLine($"{CalcDistance(points[0], points[1]):f3}");
        }
    }
}
