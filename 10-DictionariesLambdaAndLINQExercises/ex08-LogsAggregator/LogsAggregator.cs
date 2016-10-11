using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LogsAggregator
{
    static void Main(string[] args)
    {

        var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

        int entries = int.Parse(Console.ReadLine());

        for (int i = 0; i < entries; i++)
        {
            string[] entry = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string user = entry[1];
            string ip = entry[0];
            int duration = int.Parse(entry[2]);

            InsertIpAndDuration(logs, user, ip, duration);
                        
        }
        PrintUserLogs(logs);
    }

    private static void PrintUserLogs(SortedDictionary<string, SortedDictionary<string, int>> logs)
    {
        foreach (var name in logs)
        {
            string ips = string.Join(", ", name.Value.Keys.ToList());
            Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()} [{ips}]");
        }
    }

    private static void InsertIpAndDuration(SortedDictionary<string, SortedDictionary<string, int>> logs, string user, string ip, int duration)
    {
        if (!logs.ContainsKey(user))
        {
            logs.Add(user, new SortedDictionary<string, int>());
        }
        if (!logs[user].ContainsKey(ip))
        {
            logs[user].Add(ip, 0);
        }
        logs[user][ip] += duration;
    }

}

