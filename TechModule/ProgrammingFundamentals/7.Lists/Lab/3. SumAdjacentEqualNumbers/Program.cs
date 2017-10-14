using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            int index = 0;

            while (index<input.Count-1)
            {
                if (input[index]==input[index+1])
                {
                    decimal sum = input[index] + input[index + 1];
                    input.Insert(index, sum);
                    input.RemoveAt(index+1);
                    input.RemoveAt(index+1);
                    index = 0;
                    continue;
                }
                index++;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
