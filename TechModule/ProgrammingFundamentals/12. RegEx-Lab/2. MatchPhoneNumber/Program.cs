using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\s?[+359]{4}([\-\ ])[2]\1\d{3}\1\d{4}\b";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, regex);

            
            var matchedPhones = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
