using System;

namespace ex11_ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float hoursTime = hours + minutes / 60.0f + seconds / 3600.0f;
            float speed = (distance/1000.0f) / hoursTime;

            Console.WriteLine("{0:0.#######}", speed *0.2777777777f);
            Console.WriteLine("{0:0.#######}", speed);
            Console.WriteLine("{0:0.#######}", speed/1.609f);

        }
    }
}
