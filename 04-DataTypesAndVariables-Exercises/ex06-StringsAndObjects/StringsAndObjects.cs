using System;

namespace ex06_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object greetings = str1 + " " + str2;
            //Console.WriteLine(Type.GetTypeCode(greetings.GetType()));
            string str3 = Convert.ToString(greetings);
            //string str3 = (string)greetings;
            Console.WriteLine(str3);
            
        }
    }
}
