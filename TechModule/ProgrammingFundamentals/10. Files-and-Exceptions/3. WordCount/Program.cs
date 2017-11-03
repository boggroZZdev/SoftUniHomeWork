using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] {' ', ',', '!', '.', '?', ':', '\\', '\'','-'})
                .ToArray();
            string[] lookForThose = File.ReadAllText("words.txt")
                .ToLower()
                .Split(' ')
                .Select(w => w.Trim())
                .ToArray();

            Dictionary<string,int> wordsCount = new Dictionary<string, int>();

            foreach (var word in allWords)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            var output = wordsCount.OrderByDescending(x => x.Value).Where(y => lookForThose.Contains(y.Key));
            

            foreach (var keyValuePair in output)
            {
                File.AppendAllText("output.txt", keyValuePair.Key + " - "+keyValuePair.Value+Environment.NewLine);
            }
        }
    }
}
