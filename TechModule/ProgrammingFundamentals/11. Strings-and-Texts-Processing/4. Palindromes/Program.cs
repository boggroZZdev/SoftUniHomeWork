using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> words = new List<string>();

            foreach (var word in input)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (word[i]!=word[word.Length-1-i])
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    words.Add(word);
                }
            }

            words = words.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
