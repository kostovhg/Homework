using System;
using System.Collections.Generic;

class UserLogs
{
    static void Main(string[] args)
    {
        // Define sorted dictionary<[userName], sorted dictionary<[ip], [count]>>
        var spammers = new SortedDictionary<string, Dictionary<string, int>>();
        // Read first input as whole line
        string input = Console.ReadLine().Trim();

        // proceed other inputs
        while (!input.Equals("end"))
        {
            // extract [userName],[ip]
            string userName = input
                .Substring(input.IndexOf("user=") + 5)
                .ToString();
            string ip = input
                .Substring(input.IndexOf("IP=") + 3, input.IndexOf(' ')-3)
                .ToString();

            

            if (!spammers.ContainsKey(userName))
            {
                spammers.Add(userName, new Dictionary<string, int>());
            }
            if (!spammers[userName].ContainsKey(ip))
            {
                spammers[userName].Add(ip, 1);  
            }
            else
            {
                spammers[userName][ip]++;
            }
            
            input = Console.ReadLine();
        }

        foreach (var name in spammers.Keys)
        {
            List<string> result = new List<string>();
            Console.WriteLine($"{name}:");
            foreach (var ipAddres in spammers[name].Keys)
            {
                result.Add($"{ipAddres} => {spammers[name][ipAddres]}");
            }
            Console.WriteLine(string.Join(", ", result) + '.');       
        }
    }
}
