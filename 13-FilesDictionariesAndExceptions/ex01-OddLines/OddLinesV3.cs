using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_OddLines
{
    class OddLinesV3
    {
        public static void Main()
        {
            string[] inputText = File.ReadAllLines("input.txt", UTF32Encoding.Default);

            File.WriteAllLines("otputV3.txt", inputText.Where((line, index) => index % 2 == 1));
        }
    }
}
