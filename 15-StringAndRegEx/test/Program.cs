using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder(2000000);
            Stopwatch st = new Stopwatch();
            st.Start();

            for (int i = 0; i < 50000000; i++)
            {
                result.Append(Convert.ToString(i, 2));
            }

            st.Stop();

            Console.WriteLine(st.Elapsed);
        }
    }
}
