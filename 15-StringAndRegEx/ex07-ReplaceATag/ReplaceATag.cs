using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ex07_ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";

            string replacement = "[URL href=$1]$2[/URL]";

            Regex regex = new Regex(pattern);

            StringBuilder result = new StringBuilder();

            while (!text.Equals("end"))
            {
                result.Append(Regex.Replace(text, pattern, replacement) + "\r\n");
                text = Console.ReadLine();

            }

            Console.WriteLine(result);

           
        }
    }
}
