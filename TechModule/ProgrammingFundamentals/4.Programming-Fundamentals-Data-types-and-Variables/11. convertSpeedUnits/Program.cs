using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.convertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            long secondsA = hours * 3600 + minutes * 60 + seconds;
            float mPs = ((float)meters / (float)secondsA);
            double hours1 = (hours+((double) minutes/60)+ ((double)((double)seconds / 60) / 60));
            float kmH = (((float)meters / 1000) / (float)hours1);
            float mpH = (float)((double)meters / (double)1609) / (float)hours1;

            Console.WriteLine($"{mPs}\n{kmH}\n{mpH}");

        }
    }
}
