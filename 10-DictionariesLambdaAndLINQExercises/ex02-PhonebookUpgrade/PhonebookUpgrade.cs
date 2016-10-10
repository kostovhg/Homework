using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PhonebookUpgrade
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        while (!command.Equals("END"))
        {
            string[] arguments = command.Split();

            string function = arguments[0];

            switch (function)
            {
                case "A":
                    string name = arguments[1];
                    string number = arguments[2];
                    phonebook[name] = number;
                    break;
                case "S":
                    string nam = arguments[1];
                    if (phonebook.ContainsKey(nam))
                    {
                        Console.WriteLine($"{nam} -> {phonebook[nam]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {nam} does not exist.");
                    }
                    break;
                case "ListAll":
                    foreach (string n in phonebook.Keys)
                    {
                        Console.WriteLine($"{n} -> {phonebook[n]}");
                    }
                    break;
                default:
                    break;
            }

            command = Console.ReadLine();
        }
    }
}

