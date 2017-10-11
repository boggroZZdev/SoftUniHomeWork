using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];

            sequence[0] = 1;            

            for (int i = 1; i < n; i++)
            {
                sequence[i] = 0;
                int index = Math.Max(0, i - k);

                for (int j = index; j < i; j++)
                {
                    sequence[i] += sequence[j];
                }              

            }
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
