using System;

namespace ex08_EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        { 
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            char gender = Convert.ToChar(Console.ReadLine());
            ulong personalID = ulong.Parse(Console.ReadLine());
            uint uniqueNum = uint.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}" );
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {uniqueNum}");

        }
    }
}
