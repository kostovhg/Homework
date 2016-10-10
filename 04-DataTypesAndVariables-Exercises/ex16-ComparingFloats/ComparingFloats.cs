using System;

namespace ex16_ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool equal = (Math.Abs(numA - numB) < eps);

            Console.WriteLine(equal);
        }


    }
}
