using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Library currentLibrary =  new Library();
            currentLibrary.Books = new List<Book>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Book currentBook = new Book();
                currentBook.Name = input[0];
                currentBook.DateOfPublish = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                currentLibrary.Books.Add(currentBook);
            }

            DateTime givenDate  = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",CultureInfo.InvariantCulture);

            Dictionary<string,DateTime> output = new Dictionary<string, DateTime>();

            foreach (var book in currentLibrary.Books)
            {
                if (!output.ContainsKey(book.Name))
                {
                    output.Add(book.Name, book.DateOfPublish);
                }
                else
                {
                    output[book.Name] = book.DateOfPublish;
                }
                
            }

            foreach (var book in output.Where(x => x.Value>givenDate).OrderBy(x=>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
            }
        }
    }

    class Library
    {
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public DateTime DateOfPublish { get; set; }
        public string Name { get; set; }    
    }
}
