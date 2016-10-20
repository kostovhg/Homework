using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {text[i]}\r\n");
            }

        }
    }
}
