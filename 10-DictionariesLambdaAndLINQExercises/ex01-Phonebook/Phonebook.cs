using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main(string[] args)
    {
        List<string> command = new List<string>() {""};
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (command[0] != "END")
        {
            if (command[0] == "A")
            {
                phonebook[command[1]] = command[2];
            }
            else if (command[0] == "S")
            {
                if (phonebook.ContainsKey(command[1]))
                {
                    Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {command[1]} does not exist.");
                }
                
            }
            else
            {
               // Console.WriteLine("Wrong command!");
            }
            command = Console.ReadLine().Split().ToList();
        }
    }
}
