using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConvertFromBase_10toBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();
            string numberTwo = "";

            while (input[1]>0)
            {
                BigInteger index = input[1] % input[0];
                input[1] /= input[0];
                numberTwo = index.ToString() + numberTwo;
            }

            Console.WriteLine(numberTwo);
        }
    }
}
