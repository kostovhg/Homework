using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_BookLibraryModification
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
            RealeaseDate = DateTime.ParseExact(inputData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

            DateTime fromDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> libraryDic = new Dictionary<string, DateTime>();
            foreach (var book in library.Books)
            {
                if (!libraryDic.ContainsKey(book.Title) && book.RealeaseDate.CompareTo(fromDate) > 0)
                {
                    libraryDic.Add(book.Title, book.RealeaseDate);
                }
                
            }


            foreach (var item in libraryDic.OrderBy(b => b.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Key, item.Value);
            }

            //Console.WriteLine();
        }
    }
}
