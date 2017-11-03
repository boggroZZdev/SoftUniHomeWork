using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[A-F0-9]+\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            var matchesArray = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", matchesArray));
        }
    }
}
