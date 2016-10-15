using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2016, 1, 01));
            holidays.Add(new DateTime(2016, 3, 03));
            holidays.Add(new DateTime(2016, 5, 01));
            holidays.Add(new DateTime(2016, 5, 06));
            holidays.Add(new DateTime(2016, 5, 24));
            holidays.Add(new DateTime(2016, 9, 06));
            holidays.Add(new DateTime(2016, 9, 06));
            holidays.Add(new DateTime(2016, 9, 22));
            holidays.Add(new DateTime(2016, 11, 01));
            holidays.Add(new DateTime(2016, 12, 24));
            holidays.Add(new DateTime(2016, 12, 25));
            holidays.Add(new DateTime(2016, 12, 26));

            int workingDays = 0;

            for (DateTime currentDate = firstDate; currentDate <= secondDate; currentDate = currentDate.AddDays(1))
            {
                DateTime newDate = new DateTime(2016, currentDate.Month, currentDate.Day);
                if (!(holidays.Contains(newDate) || currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday))
                {
                    workingDays++;
                    //Console.WriteLine($"{newDate} -> { newDate.DayOfWeek}");
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
