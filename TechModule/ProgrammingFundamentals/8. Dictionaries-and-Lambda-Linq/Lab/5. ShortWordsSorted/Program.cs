using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = {'.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' '};
            List<string> input = Console.ReadLine().ToLower().Split(separator).ToList();
            var output = input.Where(x=> x!="")
                .Where(s => s.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ",output));

        }
    }
}
