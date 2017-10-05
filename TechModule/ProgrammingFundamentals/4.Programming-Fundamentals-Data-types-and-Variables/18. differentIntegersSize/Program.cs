using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.differentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        { 
            string number = Console.ReadLine();
            long parsed = long.Parse(number);
            try
            {
                if (parsed > long.MaxValue || parsed < long.MinValue)
                {
                    Console.WriteLine($"{number} can't fit in any type");
                }
                else
                {
                    Console.WriteLine($"{parsed} can fit in:");
                    if (parsed >= sbyte.MinValue && parsed <= sbyte.MaxValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (parsed >= byte.MinValue && parsed <= byte.MaxValue)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (parsed >= short.MinValue && parsed <= short.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (parsed >= ushort.MinValue && parsed <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (parsed >= int.MinValue && parsed <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (parsed >= uint.MinValue && parsed <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (parsed >= long.MinValue && parsed <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"{number} can't fit in any type");
                throw;
            }
            
        }
    }
}
