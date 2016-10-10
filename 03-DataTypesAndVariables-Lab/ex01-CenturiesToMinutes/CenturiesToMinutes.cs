using System;


namespace CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            long hours = 24 * days;
            ulong minutes = (ulong)(60 * hours);
            Console.WriteLine("{0} ceturies = {1} years = {2} days = {3} hours = {4} minutes",
                centuries, years, days, hours, minutes);
        }
    }
}
