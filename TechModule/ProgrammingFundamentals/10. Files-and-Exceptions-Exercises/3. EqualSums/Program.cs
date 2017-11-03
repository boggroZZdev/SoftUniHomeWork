using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;

            if (input.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        leftSum += input[j];
                    }
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        rightSum += input[j];
                    }

                    if (leftSum  == rightSum)
                    {
                        Console.WriteLine(i);
                        isFound = true;
                        break;
                    }

                }
                if (!isFound)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
