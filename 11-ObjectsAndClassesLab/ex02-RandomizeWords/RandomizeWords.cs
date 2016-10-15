using System;
using System.Linq;


class RandomizeWords
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        Random rnd = new Random();

        for (int i = 0; i < input.Length; i++)
        {
            string temp = input[i];
            int index = rnd.Next(0, input.Length - 1);
            input[i] = input[index];
            input[index] = temp;
        }

        Console.WriteLine(string.Join("\r\n", input));
    }
}

