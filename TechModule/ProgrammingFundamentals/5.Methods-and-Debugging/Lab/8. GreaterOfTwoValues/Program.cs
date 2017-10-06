﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = GetMax(a, b);
                Console.WriteLine(c);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char c = GetMax(a, b);
                Console.WriteLine(c);
            }
            else if (type == "string")
            {
                string a =Console.ReadLine();
                string b =Console.ReadLine();
                string c = GetMax(a, b);
                Console.WriteLine(c);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
               
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>0)
            {
                return a;
            }else if (b.CompareTo(a)>0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
