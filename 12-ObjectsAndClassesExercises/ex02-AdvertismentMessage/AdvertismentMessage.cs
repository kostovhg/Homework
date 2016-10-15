using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_AdvertismentMessage
{
    class AdvertismentMessage
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};


            Random rndIndex = new Random();

            for (int i = 0; i < n; i++)
            {
                string cPhrase = phrases[rndIndex.Next(0, phrases.Length)];
                string cEvent  = events[rndIndex.Next(0, events.Length)];
                string cAuthor = authors[rndIndex.Next(0, authors.Length)];
                string cTown   = cities[rndIndex.Next(0, cities.Length)];
                Console.WriteLine("{0} {1} {2} - {3}", cPhrase, cEvent, cAuthor, cTown );
            }
        }
    }
}
