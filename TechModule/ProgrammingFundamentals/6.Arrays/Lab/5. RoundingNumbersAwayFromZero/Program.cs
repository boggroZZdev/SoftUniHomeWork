﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double beforeRound = numbers[i];
                numbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{beforeRound} => {numbers[i]}");
            }
        }
    }
}