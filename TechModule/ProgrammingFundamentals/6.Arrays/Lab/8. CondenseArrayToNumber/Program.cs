using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condense = new int[numbers.Length - 1];

            if (numbers.Length==1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < condense.Length-i; j++)
                {
                    condense[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condense;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
