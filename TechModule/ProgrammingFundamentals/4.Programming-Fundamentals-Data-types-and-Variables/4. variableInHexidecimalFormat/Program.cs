﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.variableInHexidecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(a, 16));
        }
    }
}
