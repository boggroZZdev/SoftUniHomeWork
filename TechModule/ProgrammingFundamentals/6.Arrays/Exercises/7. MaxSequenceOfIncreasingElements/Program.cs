using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            int bestLenght = 1;
            int bestStart = 0;
            int currentLenght = 1;
            int currentStart = 0;
            int firstStart = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]>input[i-1])
                {
                    currentLenght++;
                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }
            }

            for (int i = bestStart; i < bestStart+bestLenght; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
