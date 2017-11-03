using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConvertFromBase_NToBase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();
            BigInteger output = 0;
            int counter = 0;
            while (input[1]>0)
            {
                
                BigInteger index = input[1] % 10;
                output += index * BigInteger.Pow(input[0], counter);
                counter++;
                input[1] /= 10;
            }

            Console.WriteLine(output);
        }
    }
}
