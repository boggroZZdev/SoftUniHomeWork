using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length>second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }
            
            StringBuilder stringNumber = new StringBuilder();

            int sum = 0;
            int remainder = 0;
            int number = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48 + remainder;
                number = sum % 10;
                stringNumber.Append(number);
                remainder = sum / 10;
                if (i == 0 && remainder > 0)
                {
                    stringNumber.Append(remainder);
                }
            }

            Console.WriteLine(stringNumber.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
