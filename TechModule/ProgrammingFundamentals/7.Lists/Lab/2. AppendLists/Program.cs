using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {'|'})
                .ToArray();

            List<int> results = new List<int>();

            for (int i = input.Length-1; i >= 0; i--)
            {
                int[] elements = input[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                results.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
