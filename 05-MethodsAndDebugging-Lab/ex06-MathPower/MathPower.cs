using System;

namespace ex06_MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number, power));
        }

        static double RaiseToPower(double number, int power)
        {
            // this method don't work in judge.
            // for 100/100 use Math.Power()
            double result = number;

            if (power != 0)
            {
                for (int i = 1; i < power; i++)
                {
                    result *= number;
                }
            }
            else
            {
                result = 1;
            }

            return result;

        }
    }
}
