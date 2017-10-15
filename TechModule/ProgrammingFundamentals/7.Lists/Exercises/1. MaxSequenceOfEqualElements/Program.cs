using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCounter = 1;
            int maxStart = 0;
            int currentCounter = 1;
            int currentStart = 0;

            List<int> output = new List<int>();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i]==input[i-1])
                {
                    currentCounter++;
                    if (currentCounter>maxCounter)
                    {
                        maxCounter = currentCounter;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentCounter = 1;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                output.Add(input[maxStart]);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
