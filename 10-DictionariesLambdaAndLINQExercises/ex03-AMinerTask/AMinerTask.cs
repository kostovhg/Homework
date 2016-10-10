using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AMinerTask
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Dictionary<string, int> metals = new Dictionary<string, int>();

        while (!input.Equals("stop"))
        {
            int quantity = int.Parse(Console.ReadLine());
            if (!metals.ContainsKey(input)) metals.Add(input, 0);
            metals[input] += quantity;
            
            input = Console.ReadLine();
        }

        foreach (string m in metals.Keys)
        {
            Console.WriteLine($"{m} -> {metals[m]}");
        }
    }
}

