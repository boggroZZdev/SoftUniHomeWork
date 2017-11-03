using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabet = new List<char>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }

            char[] input = Console.ReadLine()
                .ToCharArray();

            foreach (var character in input)
            {
                for (int i = 0; i < alphabet.Count; i++)
                {
                    if (character==alphabet[i])
                    {
                        Console.WriteLine($"{character} -> {i}");
                    }
                }
            }
        }
    }
}
