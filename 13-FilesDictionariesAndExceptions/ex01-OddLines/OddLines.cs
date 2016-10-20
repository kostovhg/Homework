using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex01_OddLines
{
    class Program
    {
        static void Main1(string[] args)
        {
            string[] inputText = File.ReadAllLines("input.txt");

            string[] outputText = new string[inputText.Length / 2];

            for (int i = 1, j = 0; i < inputText.Length; i+=2)
            {
                outputText[j] = inputText[i];
                j++;
            }

            File.WriteAllLines("otuput.txt", outputText);
        }
    }
}
