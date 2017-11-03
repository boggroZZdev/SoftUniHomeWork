using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleOne = ReadRectangle(Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Rectangle rectangleTwo = ReadRectangle(Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            bool IsInside = Rectangle.RectangleComparer(rectangleOne, rectangleTwo);

            if (IsInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }


        public static Rectangle ReadRectangle(int[] lineOne)
        { 
            return new Rectangle() { Left = lineOne[0], Top = lineOne[1], Right = lineOne[0] + lineOne[2], Bottom = lineOne[1] - lineOne[3] };
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

        public static bool RectangleComparer(Rectangle recatangleOne, Rectangle rectangleTwo)
        {
            if (recatangleOne.Left >= rectangleTwo.Left && recatangleOne.Right <= rectangleTwo.Right && recatangleOne.Top <= rectangleTwo.Top && recatangleOne.Bottom <= rectangleTwo.Bottom)
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
