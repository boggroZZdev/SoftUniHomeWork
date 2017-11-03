using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double totalSum = 0;

            foreach (string s in input)
            {
                string reworked = s.Remove(s.Length - 1, 1).Remove(0, 1);
                double number = double.Parse(reworked);
                int indexFirst = char.ToUpper(s.First()) - 64;
                int indexLast = char.ToUpper(s.Last()) - 64;
                if (Char.IsUpper(s.First()))
                {
                    number /= indexFirst;
                }
                else
                {
                    number *= indexFirst;
                }

                if (Char.IsUpper(s.Last()))
                {
                    number -= indexLast;
                }
                else
                {
                    number += indexLast;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
