using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> squareNum = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i])==(int)(Math.Sqrt(input[i])))
                {
                    squareNum.Add(input[i]);
                }
            }

            squareNum.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNum));
        }
    }
}
