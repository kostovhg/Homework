using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex10_ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:^|\s)([a-zA-Z0-9]([\w.-])+@[\w]+([.-]+[\w]+)+)";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match m in matchCollection)
            {
                Console.WriteLine(m.Groups[1].Value);
            }
        }
    }
}
