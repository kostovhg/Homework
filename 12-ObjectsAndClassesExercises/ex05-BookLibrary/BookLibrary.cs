using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }


    }

    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime RealeaseDate { get; set; }

        public string ISBN { get; set; }
        
        public decimal Price { get; set; }

        public Book(string input)
        {
            string[] inputData = input.Split().ToArray();

            Title = inputData[0];
            Author = inputData[1];
            Publisher = inputData[2];
            RealeaseDate= DateTime.ParseExact(inputData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            ISBN = inputData[4];
            Price = decimal.Parse(inputData[5]);

        }

    }
    class BookLibrary
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();
            Library library = new Library();
            library.Name = "MyLabrary";

            for (int i = 0; i < n; i++)
            {
                Book book = new Book(Console.ReadLine());
                books.Add(book);
            }
            
            library.Books = books;

            Dictionary<string, decimal> libraryDic = new Dictionary<string, decimal>();
            foreach (var book in library.Books)
            {
                if (!libraryDic.ContainsKey(book.Author))
                {
                    libraryDic.Add(book.Author, 0);
                }
                libraryDic[book.Author] += book.Price;
            }

            foreach (var item in libraryDic.OrderByDescending(b => b.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

            //Console.WriteLine();
        }
    }
}
