using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines("FileOne.txt");
            string[] input2 = File.ReadAllLines("FileTwo.txt");

            string[] output = input1.Concat(input2).ToArray();

            output = output.OrderBy(x => x).ToArray();

            File.WriteAllLines("output.txt", output);
        }
    }
}
