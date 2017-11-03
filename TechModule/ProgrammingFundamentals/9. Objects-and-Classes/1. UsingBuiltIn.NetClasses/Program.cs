using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.UsingBuiltIn.NetClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            Console.WriteLine(DateParser(date).DayOfWeek);
        }

        private static DateTime DateParser(string date)
        {
            DateTime formattedDate = DateTime.ParseExact(date,"d-M-yyyy",CultureInfo.InvariantCulture);
            return formattedDate;
        }
    }
}
