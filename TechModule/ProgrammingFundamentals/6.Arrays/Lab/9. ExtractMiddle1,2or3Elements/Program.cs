using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExtractMiddle1_2or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (one.Length==1)
            {                 
                Console.WriteLine($"{{ {one[0]} }}");
            }
            else if (one.Length%2!=0)
            {
                Console.WriteLine($"{{ {one[one.Length/2-1]}, {one[one.Length/2]}, {one[one.Length/2+1]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {one[one.Length/2-1]}, {one[one.Length/2]} }}");
            }
        }
    }
}
