using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestStart = 0;
            int bestCount = 1;
            int currentStart = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]==input[i-1])
                {
                    currentCount++;
                    currentStart = input[i];
                    if (currentCount>bestCount)
                    {
                        bestCount = currentCount;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentCount = 1;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{bestStart} ");
            }
            Console.WriteLine();
        }
    }
}
