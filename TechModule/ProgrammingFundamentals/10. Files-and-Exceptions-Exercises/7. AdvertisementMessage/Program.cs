using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.","Best product of its category.","Exceptional product.","I can't live without this product."};
            string[] events = {"Now i feel good.","I have succeeded with this product.","Makes miracles. I am happy of the results!","I cannot believe but now i feel awesome.","Try it yourself, I am very satisfied.","I feel great!"};
            string[] author = {"Diana","Petya","Stella","Elena","Katya","Iva","Annie","Eva" };
            string[] city = { "Burgas","Sofia","Plovdiv","Varna","Ruse"};


            Random rnd = new Random();

            int count = int.Parse(Console.ReadLine());

            for (int index = 0; index < count; index++)
            {
                int phrase = rnd.Next(0, phrases.Length);
                int eventss = rnd.Next(0, events.Length);
                int authors = rnd.Next(0, author.Length);
                int cities = rnd.Next(0, city.Length);

                Console.WriteLine($"{phrases[phrase]} {events[eventss]} {author[authors]} - {city[cities]}.");
            }
        }
    }
}
