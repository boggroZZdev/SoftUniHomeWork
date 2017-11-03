using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TextFilter
{
    class Program           //  
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));

                }
            }
            Console.WriteLine(input);

        }
    }
}
