using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                var num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.Write(numbers[i]+" ");
            }
        }   
    }
}
