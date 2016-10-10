using System;
using System.Numerics;


namespace ex18_DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                Convert.ToInt64(number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} can't fit in any type", number);
                return;
            }

            Console.WriteLine("{0} can fit in:", number);
            if (Convert.ToInt64(number) <= sbyte.MaxValue &&
                    Convert.ToInt64(number) >= sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (Convert.ToInt64(number) <= byte.MaxValue &&
                Convert.ToInt64(number) >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            if (Convert.ToInt64(number) <= short.MaxValue &&
                    Convert.ToInt64(number) >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (Convert.ToInt64(number) <= ushort.MaxValue &&
                Convert.ToInt64(number) >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }
            if (Convert.ToInt64(number) <= int.MaxValue &&
                    Convert.ToInt64(number) >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (Convert.ToInt64(number) <= uint.MaxValue &&
                Convert.ToInt64(number) >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }
            if (Convert.ToInt64(number) <= long.MaxValue &&
                    Convert.ToInt64(number) >= long.MinValue)
            {
                Console.WriteLine("* long");
            }

        }
    }
}
