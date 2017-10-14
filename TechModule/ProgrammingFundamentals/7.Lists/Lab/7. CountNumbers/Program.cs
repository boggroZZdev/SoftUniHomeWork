using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int[] inputCounter = new int[1000];
            int counter = 0;

            foreach (int number in input)
            {
                inputCounter[number]++;
            }

            input.Sort();

            while (counter<input.Count-1)
            {
                if (input[counter]==input[counter+1])
                {
                    input.Remove(input[counter]);
                    counter=0;
                }
                else
                {
                    counter++;
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{input[i]} -> {inputCounter[input[i]]}");
            }
        }
    }
}
