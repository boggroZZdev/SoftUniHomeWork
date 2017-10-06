using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = Sums(number);
            Console.WriteLine(sum);
        }

        static int Sums(int number)
        {
            number = Math.Abs(number);
            int sumOdds = 0;
            int sumEvens = 0;
            while (number>0)
            {
                int n = number % 10;
                if (n%2==0)
                {
                    sumEvens += n;
                }
                else
                {
                    sumOdds += n;
                }
                number /= 10;
            }
            return sumEvens * sumOdds;
        }
    }
}
