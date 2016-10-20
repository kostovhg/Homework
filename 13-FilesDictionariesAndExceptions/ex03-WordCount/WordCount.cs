using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var wordsCount = new Dictionary<string, int>();

            //List<string> words = new List<string>();

            string[] words = File.ReadAllText("words.txt").ToLower().Split();

            string[] text = File.ReadAllText("text.txt").ToLower()
                .Split(new char[] { '\n' , '\r', ' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
                wordsCount[word] = 0;

            foreach (string word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            wordsCount = wordsCount.OrderByDescending(w => w.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in wordsCount)
            {
                File.AppendAllText("output.txt", $"{pair.Key} - {pair.Value}\r\n");
            }
        }
    }
}
