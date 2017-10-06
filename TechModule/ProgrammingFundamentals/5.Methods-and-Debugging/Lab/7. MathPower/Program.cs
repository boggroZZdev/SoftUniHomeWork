using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            var output = TotalSum(number, power);
            Console.WriteLine(output);
        }

        static double TotalSum(double number, int times)
        {
            double sum = 1;

            for (int i = 1; i <=times; i++)
            {
                sum *= number;
            }
            return sum;
        }
    }
}
