using System;

namespace ex13_VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char symbol = Convert.ToChar(Console.ReadLine());
            string output = "";

            if (symbol >= '0' && symbol <= '9')
            {
                output = "digit";
            }
            //else if (symbol == 'a' || symbol == 'e' ||
            //         symbol == 'i' || symbol == 'o' ||
            //         symbol == 'u' || symbol == 'y')
            else if ("aeiouAEIOU".IndexOf(symbol) >= 0)
            {
                output = "vowel";
            }
            else
            {
                output = "other";
            }

            Console.WriteLine(output);
        }
    }
}
