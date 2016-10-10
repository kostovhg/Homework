using System;

namespace ex05_CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine(area);

        }

        static double GetTriangleArea(double widht, double height)
        {
            return widht * height / 2;
        }
    }
}
