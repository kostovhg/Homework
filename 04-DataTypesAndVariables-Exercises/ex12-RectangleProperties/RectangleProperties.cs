using System;

namespace ex12_RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(width * 2 + height * 2);
            Console.WriteLine(width * height);
            Console.WriteLine(Math.Sqrt(width * width + height * height));
        }
    }
}
