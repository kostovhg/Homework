using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_IntersectionOfCircles
{
    class IntersectionOfCircles
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        class Circle
        {
            public Point Centre { get; set;}

            public int Radius { get; set; }

            public static Circle ReadCircle(string input)
            {
                int[] data = input.Split().Select(int.Parse).ToArray();

                Point point = new Point(data[0], data[1]);
                Circle circle = new Circle(point, data[2]);

                return circle;
            }

            public Circle(Point centre, int radius)
            {
                this.Centre = centre;
                this.Radius = radius;
            }

            public static bool IntersectWithCircle(Circle c1, Circle c2)
            {
                int deltaX = Math.Abs(c1.Centre.X - c2.Centre.X);
                int deltaY = Math.Abs(c1.Centre.Y - c2.Centre.Y);
                double centreDistance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                int radiusSum = c1.Radius + c2.Radius;

                return radiusSum >= centreDistance;
            }
        }
        static void Main(string[] args)
        {
            Circle c1 = Circle.ReadCircle(Console.ReadLine());
            Circle c2 = Circle.ReadCircle(Console.ReadLine());

            Console.WriteLine(Circle.IntersectWithCircle(c1, c2) ? "Yes" : "No");


        }
    }
}
