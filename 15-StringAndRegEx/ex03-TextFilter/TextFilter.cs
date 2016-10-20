using System;

namespace ex03_TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] ban = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < ban.Length; i++)
            {
                text = text.Replace(ban[i], new string('*', ban[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
