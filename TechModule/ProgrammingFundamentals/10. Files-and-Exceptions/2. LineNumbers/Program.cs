using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines("input.txt");
            int counter = 1;

            var numberedLines = allLines.Select((line, index) => $"{index + 1}.  {line}");
            File.WriteAllLines("output.txt", numberedLines);
        }
    }
}
