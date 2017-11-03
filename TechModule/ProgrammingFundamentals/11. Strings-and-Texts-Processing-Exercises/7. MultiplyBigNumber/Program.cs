using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int power = int.Parse(Console.ReadLine());

            if (number == "0" || power == 0 || number == "") 
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder stringNumber = new StringBuilder();

            int remainder = 0;
            int numberSum = 0;
            int sum = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sum = (number[i] - 48) * power + remainder;
                remainder = sum / 10;
                numberSum = sum % 10;
                stringNumber.Append(numberSum);
                if (i == 0 && remainder > 0)
                {
                    stringNumber.Append(remainder);
                }
            }

            Console.WriteLine(new string(stringNumber.ToString().ToCharArray().Reverse().ToArray()));
        }
    }
}
