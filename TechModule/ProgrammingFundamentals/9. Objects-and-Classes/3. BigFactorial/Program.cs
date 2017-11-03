using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(BigIntFactorial(input));
        }

        public static BigInteger BigIntFactorial(int input)
        {
            BigInteger sum = 1;

            for (int i = 1; i <= input; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
