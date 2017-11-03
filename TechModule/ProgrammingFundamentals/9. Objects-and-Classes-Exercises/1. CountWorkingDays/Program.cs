using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",CultureInfo.InvariantCulture);

            int workingDaysCounter = 0;

            for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !(i.Month == 1 && i.Day == 1) && !(i.Month == 3 && i.Day == 3) && !(i.Month == 5 && i.Day == 1) && !(i.Month == 5 && i.Day == 6) && !(i.Month == 5 && i.Day == 24) && !(i.Month == 9 && i.Day == 6) && !(i.Month == 9 && i.Day == 22) && !(i.Month == 11 && i.Day == 1) && !(i.Month == 12 && i.Day == 24) && !(i.Month == 12 && i.Day == 25) && !(i.Month == 12 && i.Day == 26))
                {
                    workingDaysCounter++;
                }   
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
