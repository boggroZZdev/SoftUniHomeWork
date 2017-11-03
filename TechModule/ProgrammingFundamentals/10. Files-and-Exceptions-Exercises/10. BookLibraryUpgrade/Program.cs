using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BookLibraryUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, DateTime> output = new Dictionary<string, DateTime>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = command[0];
                DateTime dateOfPublish = DateTime.ParseExact(command[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                output[name] = dateOfPublish;
            }

            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",CultureInfo.InvariantCulture);

            var reworkedOutput = output.Where(x => x.Value > givenDate).OrderBy(x => x.Value).ThenBy(x => x.Key);

            foreach (var keyValuePair in reworkedOutput)
            {
                int day = keyValuePair.Value.Day;
                int month = keyValuePair.Value.Month;
                int year = keyValuePair.Value.Year;
                Console.WriteLine($"{keyValuePair.Key} -> {day}.{month:D2}.{year}");
            }
        }
    }
}
