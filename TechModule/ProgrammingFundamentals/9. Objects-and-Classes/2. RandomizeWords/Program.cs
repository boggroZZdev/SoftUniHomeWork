using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int newPossition = rnd.Next(input.Length);
                string word = input[i];
                input[i] = input[newPossition];
                input[newPossition] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
