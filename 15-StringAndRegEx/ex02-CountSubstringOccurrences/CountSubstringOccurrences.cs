using System;

namespace ex02_CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string str = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(str);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(str, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
