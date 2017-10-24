using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;
            int[] firstPart = input.Take(k).Reverse().ToArray();
            int[] secondPart = input.Reverse().Take(k).ToArray();
            int[] thirdPart = input.Skip(k).Take(2 * k).ToArray();
            int[] rowOne = firstPart.Concat(secondPart).ToArray();
            int[] rowTwo = thirdPart;

            var sum = rowOne.Select((x, index) => x + rowTwo[index]);
            Console.WriteLine(string.Join(" ",sum));
        }

    }
}
