using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] lines = File.ReadAllLines("input.txt");

            var oddLines = lines.Where((line, index) => index % 2 != 0);
            File.WriteAllLines("odd-lines.txt",oddLines);
        }
    }
}
