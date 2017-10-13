using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            char[] inputLetters = input.ToCharArray();

            for (int i = 0; i < inputLetters.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (inputLetters[i] == alphabet[j])
                    {
                        Console.WriteLine($"{inputLetters[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
