using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HandsOfCards
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> inResults = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (!input.Equals("JOKER") && input.IndexOf(" ") > 1)
        {
            string name = input.Substring(0, input.IndexOf(":"));
            
            List<string> cards = input.Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            if (inResults.ContainsKey(name))
            {
                inResults[name].AddRange(cards);
            }
            else
            {
                inResults.Add(name, cards);
            }

            input = Console.ReadLine();
        }

        foreach (var name in inResults.Keys)
        {
            Console.WriteLine($"{name}: {CardsSumPower(inResults[name])}");
        }
   }

    static int CardsSumPower(List<string> cards)
    {
        int power = 0;
        int score = 0;
        foreach (string card in cards)
        {
            string suit = card.Substring(card.Length - 1);
            string pow = card.Substring(0, card.Length -1);
            switch (pow)
            {
                case "J": score = 11; break;
                case "Q": score = 12; break;
                case "K": score = 13; break;
                case "A": score = 14; break;
                default: score = int.Parse(pow);
                    break;
            }

            switch (suit)
            {
                case "S": score *= 4; break;
                case "H": score *= 3; break;
                case "D": score *= 2; break;
                case "C": score *= 1; break;
                default:
                    break;
            }
            power += score;
        }

        

        return power;
    }
}
