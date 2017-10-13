using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();
            int bestStart = 0;
            int bestLenght = 1;
            int currentStart = 0;
            int currentLen = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]==input[currentStart])
                {
                    currentLen++;
                    if (bestLenght<currentLen)
                    {
                        bestLenght = currentLen;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }

            for (int i = bestStart; i < bestLenght+bestStart; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
