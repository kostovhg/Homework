using System;

namespace ex19_TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            ulong totalFiltered = (ulong)amount * (ulong)filterTime; // time to filter all pictures in seconds
            ulong goodPics = (ulong)Math.Ceiling((filterFactor / 100.0)*amount);
            ulong uploadGood = goodPics * (ulong)uploadTime;

            ulong totalSeconds = totalFiltered + uploadGood;

            int days = (int)Math.Floor(totalSeconds / 86400.0);
            int hours = (int)Math.Floor((totalSeconds % 86400) / 3600.0);
            int minutes = (int)Math.Floor(((totalSeconds % 86400) % 3600) / 60.0);
            int seconds = (int)((totalSeconds % 86400) % 3600) % 60;

            Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);
        }
    }
}
