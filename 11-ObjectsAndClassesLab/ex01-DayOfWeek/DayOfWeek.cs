using System;
using System.Globalization;

class DayOfWeek
{
    static void Main(string[] args)
    {
            
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);
    }
}
