using System;
using System.Collections.Generic;

namespace ex07_PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            
            uint startNum = uint.Parse(Console.ReadLine());
            uint endNum = uint.Parse(Console.ReadLine());
            List<uint> listOfPrimes = FindPrimesInRange(startNum, endNum);

            string numberToPrint = String.Join(", ", listOfPrimes.ToArray());

            Console.WriteLine(numberToPrint);
        }

        static List<uint> FindPrimesInRange(uint startNum, uint endNum)
        {
            List<uint> primeList = new List<uint>();
            for (uint i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }

        

        static bool IsPrime(uint num) 
        {
            if (num <= 1) return false;
            else if (num <= 3) return true;
            else if (num % 2 == 0 || num % 3 == 0) return false;
            for (uint i = 5; i <= (uint)Math.Sqrt(num); i++)
            {
                if (num % i == 0 ) return false;
            }
            return true;
        }
    }
}
