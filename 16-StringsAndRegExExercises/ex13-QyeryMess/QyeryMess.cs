using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// https://regex101.com/delete/4w6iP9sOIwgXSEY81DQra1Ww

// leave that. There is no time. Copyed code from:
// https://github.com/KatyaMarincheva/SoftUni-Fundamental-Level/blob/master/01.%20Advanced%20C%23/Exam%20Preparation/Exam-Preparation-Advanced-CSharp/04.%20Query-Mess/QueryMess.cs

namespace ex13_QyeryMess
{
    class QyeryMess
    {
        static void Main()
        {
            // regex patterns
            string pattern = @"([^&=?]*)=([^&=]*)";
            string regex = @"((%20|\+)+)";

            // input and matching
            string inputLine;

            while (!((inputLine = Console.ReadLine()) == "END"))
            {
                Regex pairs = new Regex(pattern);
                MatchCollection matches = pairs.Matches(inputLine);

                // storing matching fields and values into a dictionary, per line of input
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, regex, word => " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, regex, word => " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else if (results.ContainsKey(field))
                    {
                        results[field].Add(value);
                    }
                }

                // printing
                foreach (var pair in results)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
            }
        }
    }
}
