using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
    static void Main(string[] args)
    {
        // Initialize dictionary <player name, cards<value>>
        Dictionary<string, List<string>> inResults = new Dictionary<string, List<string>>();

        // Take first row of Player: Card, Card, Card... 
        string input = Console.ReadLine();

        // Untill command is "JOKER", and input is longer than one word, repeat:
        while (!input.Equals("JOKER") && input.IndexOf(" ") > 1)
        {
            // Separate input by ":", and thake first word as Player name
            string name = input.Substring(0, input.IndexOf(":"));

            // Take all words after first one, remove ' ' and ',' ant add them to list "cards", only unique only
            List<string> cards = input
                .Substring(input.IndexOf(':') + 1)
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();

            // if such key exist in dictionary...
            if (inResults.ContainsKey(name))
            {
                // ... concat existing list with new one, and remove duplicates
                inResults[name] = inResults[name]
                    .Concat(cards)
                    .Distinct()
                    .ToList();
            }
            else
            {
                // add list of unique cards
                inResults.Add(name, cards);
            }

            // Read new input
            input = Console.ReadLine();
        }

        // Print the result after 
        foreach (var name in inResults.Keys)
        {
            Console.WriteLine($"{name}: {(CardsSumPower(inResults[name]))}");
        }
    }

    // Check result for all cards in players card
    static int CardsSumPower(List<string> cards)
    {
        int power = 0;
        int score = 0;
        foreach (string card in cards)
        {
            string suit = card.Substring(card.Length - 1);
            string pow = card.Substring(0, card.Length - 1);
            switch (pow)
            {
                case "J": power = 11; break;
                case "Q": power = 12; break;
                case "K": power = 13; break;
                case "A": power = 14; break;
                default:
                    power = int.Parse(pow);
                    break;
            }

            switch (suit)
            {
                case "S": power *= 4; break;
                case "H": power *= 3; break;
                case "D": power *= 2; break;
                case "C": power *= 1; break;
                default:
                    break;
            }
            score += power;
        }

        return score;
    }
}
