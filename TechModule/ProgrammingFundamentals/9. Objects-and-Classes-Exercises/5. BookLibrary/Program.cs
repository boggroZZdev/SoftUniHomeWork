using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Library currentLibrary = new Library();
            currentLibrary.Books = new List<Book>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Book currentBook = new Book();
                currentBook.Author = input[1];
                currentBook.Price = double.Parse(input[5]);
                currentLibrary.Books.Add(currentBook);
            }

            Dictionary<string, double> output = new Dictionary<string, double>();

            foreach (var whatever in currentLibrary.Books)
            {
                if (!output.ContainsKey(whatever.Author))
                {
                    output.Add(key:whatever.Author, value:whatever.Price);
                }
                else
                {
                    output[whatever.Author] += whatever.Price;
                }
            }

            var ordered = output.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var author in ordered)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }

    class Library
    {
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
