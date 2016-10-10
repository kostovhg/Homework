using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FixEmails
{
    static void Main(string[] args)
    {
        string inputName = Console.ReadLine();
        Dictionary<string, List<string>> emailRecords = new Dictionary<string, List<string>>();

        while (!inputName.Equals("stop"))
        {
            List<string> email = Console.ReadLine().Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            emailRecords[inputName] = email;

            inputName = Console.ReadLine();
        }

        foreach (string name in emailRecords.Keys)
        {

            if (!emailRecords[name][1].Equals("us") &&
                !emailRecords[name][1].Equals("uk"))

            {
                Console.WriteLine("{0} -> {1}", name, string.Join(".", emailRecords[name]).ToString());
            }
        }   
        
    }
}
