using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ChangeLIst
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> command = new List<string>();

            while (!command.Contains("Odd")&&!command.Contains("Even"))
            {
                command = new List<string>(Console.ReadLine()
                    .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries));

                if (command.Contains("Delete"))
                {
                    int elementToDelete = int.Parse(command[1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i]==elementToDelete)
                        {
                            input.Remove(input[i]);
                            i--;
                        }
                    }
                }
                else if (command.Contains("Insert"))
                {
                    int elementToInsert = int.Parse(command[1]);
                    int positionToInsert = int.Parse(command[2]);
                    input.Insert(positionToInsert, elementToInsert);
                }
            }

            if (command.Contains("Odd"))
            {
                foreach (int num in input)
                {
                    if (num%2!=0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            else if (command.Contains("Even"))
            {
                foreach (int num in input)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
