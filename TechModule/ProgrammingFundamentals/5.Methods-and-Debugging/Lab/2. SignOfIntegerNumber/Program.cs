using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            PrintSign(a);
        }

        static void PrintSign(int sign)
        {
            if (sign > 0)
            {
                Console.WriteLine($"The number {sign} is positive.");
            }
            else if (sign < 0)
            {
                Console.WriteLine($"The number {sign} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {sign} is zero.");
            }
        }
    }
}
