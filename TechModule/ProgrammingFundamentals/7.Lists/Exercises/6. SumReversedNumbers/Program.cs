using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int counter = 0;
                while (input[i]>0)
                {
                    int num = input[i] % 10;
                    counter = counter * 10 + num;
                    input[i] /= 10;

                }
                sum += counter;
            }

            Console.WriteLine(sum);
        }
    }
}
