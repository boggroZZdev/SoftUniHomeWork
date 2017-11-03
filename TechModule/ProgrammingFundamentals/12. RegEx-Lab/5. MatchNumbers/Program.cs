using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?((?=\s)|$)";

            string input = Console.ReadLine();

            var numbersMatched = Regex.Matches(input, regex);

            foreach (Match match in numbersMatched)
            {
                Console.Write(match.Value+" ");
            }

            Console.WriteLine();
        }
    }
}
