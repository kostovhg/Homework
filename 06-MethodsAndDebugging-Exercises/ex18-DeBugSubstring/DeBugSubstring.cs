using System;

public class DeBugSubstring
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p'; // changed ASCII 1088 cyrilic 'p' with 112 latin 'p'
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = jump + 1; // increase index with +1

                if (endIndex + i > text.Length) // check the sum of i and endIndex to be lower tahn text.Length
                {
                    endIndex = text.Length - i; // set endIndex to diffrence between length and current i
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
