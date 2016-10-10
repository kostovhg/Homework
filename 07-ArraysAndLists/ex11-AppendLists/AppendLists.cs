using System;
using System.Collections.Generic;
using System.Linq;

namespace ex11_AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            //string input = "1| 4 5 6 7  |  8 9";
            List<string> tokens = new List<string>(Console.ReadLine().Split('|').ToList());
            tokens.Reverse();

            List<string> result = new List<string>();


            foreach (var item in tokens)
            {
                List<string> nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
