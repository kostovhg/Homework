using System;

namespace ex08_RefractorVolumeOfPyramid
{
    class RefractorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double widith = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double vol = (length * widith * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", vol);

        }
    }
}
