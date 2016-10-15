using System;
using System.Linq;

namespace ex04_DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            Console.WriteLine($"{CalcDistance(p1, p2):f3}");
        }

        private static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }

        static double CalcDistance( Point point1, Point point2)
        {
            double distance = 0.0d;

            int x = point1.X - point2.X;
            int y = point1.Y - point2.Y;

            distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
    }
}
