using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MostFrequentNumber
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
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[j]==input[i])
                    {
                        currentCount++;
                        if (currentCount>maxCount)
                        {
                            maxCount = currentCount;
                            bestStart = input[i];
                        }
                    }
                    
                        

                }
                currentCount = 1;
            }

            Console.WriteLine(bestStart);
        }
    }
}
