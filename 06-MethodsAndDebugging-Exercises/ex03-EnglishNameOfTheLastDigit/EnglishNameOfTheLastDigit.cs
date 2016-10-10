using System;

namespace ex03_EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            //char lastDigit = num[num.Length-1];
            Console.WriteLine(DigitName(num[num.Length - 1]));
        }

        static string DigitName(char n)
        {
            string dName = "none";
            switch (Math.Abs(n))
            {
                case '0': dName = "zero"; break;
                case '1': dName = "one"; break;
                case '2': dName = "two"; break;
                case '3': dName = "three"; break;
                case '4': dName = "four"; break;
                case '5': dName = "five"; break;
                case '6': dName = "six"; break;
                case '7': dName = "seven"; break;
                case '8': dName = "eight"; break;
                case '9': dName = "nine"; break;

                default:
                    break;
            }
            return dName;
        }
    }
}
