using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] topRow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] bottomRow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (topRow[0]<bottomRow[0])
            {
                Console.WriteLine(string.Join("",topRow));
                Console.WriteLine(string.Join("",bottomRow));
            }
            else if (bottomRow[0]<topRow[0])
            {
                Console.WriteLine(string.Join("", bottomRow));
                Console.WriteLine(string.Join("", topRow));
            }
            else
            {
                int minLenght = Math.Min(topRow.Length, bottomRow.Length);

                bool isDiff = false;

                for (int i = 1; i < minLenght; i++)
                {
                    if (topRow[i]!=bottomRow[i])
                    {
                        isDiff = true;
                        if (topRow[i]>bottomRow[i])
                        {
                            Console.WriteLine(string.Join("", bottomRow));
                            Console.WriteLine(string.Join("", topRow));
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", topRow));
                            Console.WriteLine(string.Join("", bottomRow));
                        }
                    }
                }
                if (isDiff==false)
                {
                    if (topRow.Length<bottomRow.Length)
                    {
                        Console.WriteLine(string.Join("", topRow));
                        Console.WriteLine(string.Join("", bottomRow));
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", bottomRow));
                        Console.WriteLine(string.Join("", topRow));
                    }
                }
            }
        }
    }
}
