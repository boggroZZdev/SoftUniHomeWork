using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArgs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Circle firstCircle = new Circle();
            Point firstCenter = new Point();
            firstCenter.X = firstArgs[0];
            firstCenter.Y = firstArgs[1];
            firstCircle.Radius = firstArgs[3];
            firstCircle.Center = firstCenter;
            int[] secondArgs = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            Circle secondCircle = new Circle();
            Point secondCenter = new Point();
            secondCenter.X = secondArgs[0];
            secondCenter.Y = secondArgs[1];
            secondCircle.Radius = secondArgs[3];
            secondCircle.Center = secondCenter;

            if (DoIntersect(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool DoIntersect(Circle one, Circle two)
        {
            if (DistanceBetweenCenters(one.Center, two.Center)>one.Radius+two.Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double DistanceBetweenCenters(Point one, Point two)
        {
            double distance = Math.Pow(one.X - two.X, 2) + Math.Pow(one.Y - two.Y, 2);
            return distance;
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
