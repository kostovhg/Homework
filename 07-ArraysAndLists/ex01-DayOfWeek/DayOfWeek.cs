using System;

namespace ex01_DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"  };
            int n = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(daysOfWeek[n-1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Day!");
                //throw;
            }
        }
    }
}
