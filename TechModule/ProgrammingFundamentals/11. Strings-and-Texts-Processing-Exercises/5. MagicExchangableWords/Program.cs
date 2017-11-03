using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MagicExchangableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Console.WriteLine(AreExchangable(words[0], words[1]).ToString().ToLower());
        }

        public static bool AreExchangable(string str1, string str2)
        {
            List<char> listOne = new List<char>();
            List<char> listTwo = new List<char>();
            foreach (char c in str1)
            {
                listOne.Add(c);
            }
            foreach (char c in str2)
            {
                listTwo.Add(c);
            }

            listOne = listOne.Distinct().ToList();
            listTwo = listTwo.Distinct().ToList();
            if (listOne.Count == listTwo.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
