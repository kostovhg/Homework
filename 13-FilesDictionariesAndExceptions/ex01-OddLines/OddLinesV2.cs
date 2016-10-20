using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_OddLines
{
    class OddLinesV2
    {
        public static void Main2()
        {
            string[] inputText = File.ReadAllLines("input.txt", UTF32Encoding.Default);

            File.WriteAllText("otputV2.txt", "");

            for (int i = 1; i < inputText.Length; i +=2)
            {
                File.AppendAllText("otputV2.txt", inputText[i] + "\r\n");
            }   
        }
    }
}
