using System;

namespace ex10_CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422f);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microsedonds = milliseconds * 1000;
            decimal nanoseconds = microsedonds * 1000;

            Console.Write($"{centuries} centuries = ");
            Console.Write($"{years} years = ");
            Console.Write($"{days} days = ");
            Console.Write($"{hours} hours = ");
            Console.Write($"{minutes} minutes = ");
            Console.Write($"{seconds} seconds = ");
            Console.Write("{0:F0} milliseconds = ", milliseconds);
            Console.Write("{0:F0} microseconds = ", microsedonds);
            Console.WriteLine("{0:F0} nanoseconds", nanoseconds);
        }
    }
}
