using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arraySum = new int[Math.Max(arrayOne.Length,arrayTwo.Length)];

            for (int i = 0; i < arraySum.Length; i++)
            {               
                arraySum[i] = arrayOne[i%arrayOne.Length] + arrayTwo[i%arrayTwo.Length];
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
