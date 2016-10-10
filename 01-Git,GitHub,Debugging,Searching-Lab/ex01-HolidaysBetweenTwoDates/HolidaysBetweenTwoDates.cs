using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture); // changed format from "dd.m.yyyy" 
        var endDate = DateTime.ParseExact(Console.ReadLine(),
           "d.M.yyyy", CultureInfo.InvariantCulture); // changed format from "dd.m.yyyy" 
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1)) // changed date to increase with date.AddDays
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || // changed condition operator from "&&"
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        }
        Console.WriteLine(holidaysCount);
    }
}
