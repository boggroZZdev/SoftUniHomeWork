using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double,int> result = new SortedDictionary<double, int>();

            foreach (double num in input)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                {
                    result[num] = 1;
                }
            }

            foreach (double num in result.Keys)
            {
                Console.WriteLine($"{num} -> {result[num]}");
            }    
        }
    }
}
