using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string word in input)
            {
                bool isLower = false;
                bool isUpper = false;
                bool isSymbol = false;

                foreach (char letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        isLower = true;
                    }
                    else if(char.IsUpper(letter))
                    {
                        isUpper = true;
                    }
                    else if (!char.IsLetter(letter))
                    {
                        isSymbol = true;
                    }
                }

                if (!isLower && isUpper && !isSymbol)
                {
                    upperCase.Add(word);
                }
                else if (!isUpper && isLower && !isSymbol)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
            

        }
    }
}
