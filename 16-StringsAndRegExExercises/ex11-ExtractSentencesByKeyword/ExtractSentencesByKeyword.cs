using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex11_ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string pat = Console.ReadLine();
            string pattern = @"(?:^|\s)([^.!?]*((" +pat + @" )|( " + pat + @" ))[^.?!]*[^.?!])";
            string input = Console.ReadLine();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0}", m.Groups[1].Value);
            }
        }
    }
}
