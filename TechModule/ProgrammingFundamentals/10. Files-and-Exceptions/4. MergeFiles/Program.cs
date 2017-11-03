using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllLines("fileOne.txt");
            string[] secondFile = File.ReadAllLines("fileTwo.txt");
            File.Delete("output.txt");
            List<string> output = firstFile.Concat(secondFile).ToList();

            File.WriteAllLines("output.txt",output.OrderBy(x=>x));
        }
    }
}
