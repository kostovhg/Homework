using System;

namespace ex11_GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            switch (figure)
            {
                case "triangle": TriangleArea(); break;
                case "square": SquareArea(); break;
                case "rectangle": RectangleArea();  break;
                case "circle": CircleArea();  break;
                default:
                    break;
            }

        }

        private static void CircleArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * side * Math.PI);
        }

        private static void SquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * side);
        }

        private static void RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", width * height);
        }

        private static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", side * height / 2);

        }
    }
}
