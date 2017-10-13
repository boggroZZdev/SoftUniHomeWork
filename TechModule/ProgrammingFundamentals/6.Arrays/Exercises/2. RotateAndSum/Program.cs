using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] shiftedRight = new int[numbers.Length];
                            
            for (int i = 0; i < k; i++)
            {               
                RotateArray(numbers);
                for (int j = 0; j < shiftedRight.Length; j++)
                {
                    shiftedRight[j] = shiftedRight[j] + numbers[j];
                }
            }          
            Console.WriteLine(string.Join(" ", shiftedRight));           
        }

        private static void RotateArray(int[] numbers)
        {
            var lastDigit = numbers.Last();
            for (int i = numbers.Length-1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = lastDigit;
        }
    }
}
