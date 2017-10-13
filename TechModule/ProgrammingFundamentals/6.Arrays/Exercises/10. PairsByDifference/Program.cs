using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int differenceIndex = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i==j)
                    {
                        break;
                    }
                    else
                    {
                        if (Math.Abs(input[i]-input[j])==differenceIndex)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
