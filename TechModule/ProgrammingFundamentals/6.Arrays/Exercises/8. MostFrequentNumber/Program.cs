using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] input = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int[] spaces = new int[65535];

            foreach (ushort num in input)
            {
                spaces[num]++;
            }

            int mostFrequent = spaces.Max();

            for (int i = 0; i < input.Length; i++)
            {
                if (spaces[input[i]]==mostFrequent)
                {
                    Console.WriteLine(input[i]);
                    break;
                }
            }
        }
    }
}
