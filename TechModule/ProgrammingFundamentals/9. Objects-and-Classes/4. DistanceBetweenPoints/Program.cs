using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPoint = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondPoint = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Point pointOne = new Point();
            Point pointTwo = new Point();

            pointOne.X = firstPoint[0];
            pointOne.Y = firstPoint[1];
            pointTwo.X = secondPoint[0];
            pointTwo.Y = secondPoint[1];

            CalcDistance(pointOne.X, pointOne.Y, pointTwo.X, pointTwo.Y);
        }

        private static void CalcDistance(int x1, int y1,int x2,int y2)
        {
            double distance = Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2);
            Console.WriteLine(Math.Sqrt(distance));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
