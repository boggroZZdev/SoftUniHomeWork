using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Console.WriteLine(Multiplier(input[0], input[1]));
        }

        public static int Multiplier(string str1, string str2)
        {
            int longerString = Math.Max(str1.Length, str2.Length);
            int shorterString = Math.Min(str1.Length, str2.Length);
            int sum = 0;
            if (longerString==shorterString)
            {
                for (int i = 0; i < shorterString; i++)
                {
                    sum += str1[i] * str2[i];
                }
            }
            else
            {
                for (int i = 0; i < shorterString; i++)
                {
                    sum += str1[i] * str2[i];
                }
                if (longerString==str1.Length)
                {
                    for (int i = shorterString; i < longerString; i++)
                    {
                        sum += str1[i];
                    }
                }
                else
                {
                    for (int i = shorterString; i < longerString; i++)
                    {
                        sum += str2[i];
                    }
                }
            }
            return sum;
        }
    }
}
