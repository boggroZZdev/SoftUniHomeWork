using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] secondLine = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]==secondLine[0])
                {
                    for (int j = 1; j <= secondLine[1]; j++)
                    {
                        if (i-j<0)
                        {
                            break;
                        }
                        else
                        {
                            input[i - j] = 0;
                        }
                    }

                    for (int j = 1; j <= secondLine[1]; j++)
                    {
                        if (i + j > input.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            input[i + j] = 0;
                        }
                    }

                    input[i] = 0;
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}
