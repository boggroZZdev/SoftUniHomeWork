using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            FindThePrimes(input);
            Console.WriteLine();
        }

        static void FindThePrimes(int input)
        {
            bool[] isPrime = new bool[input+1];

            for (int i = 0; i <= input; i++)
            {
                isPrime[i] = true;
            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i]==true)
                {
                    for (int j = 2; (j*i) <= input; j++)
                    {
                        isPrime[j * i] = false;
                    }
                }
            }
            
            for (int i = 2; i <= input; i++)
            {
                if (isPrime[i]==true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
