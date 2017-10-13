using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] leftPiece = new int[input.Length / 4];
            int[] rightPiece = new int[input.Length / 4];
            int[] centerPiece = new int[input.Length / 2];

            GenerateArrays(input, leftPiece, rightPiece, centerPiece);

            Array.Reverse(leftPiece);
            Array.Reverse(rightPiece);

            int[] topRow = new int[leftPiece.Length + rightPiece.Length];
            leftPiece.CopyTo(topRow, 0);
            rightPiece.CopyTo(topRow, leftPiece.Length);

            GenerateOutput(topRow, centerPiece);
            Console.WriteLine(string.Join(" ", GenerateOutput(topRow, centerPiece)));
        }

        private static  int[] GenerateOutput(int[] topRow, int[] centerPiece)
        {
            int[] sum = new int[centerPiece.Length];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = topRow[i] + centerPiece[i];
            }

            return sum;
        }

        private static void GenerateArrays(int[] input, int[] leftPiece, int[] rightPiece, int[] centerPiece)
        {
            for (int i = 0; i < leftPiece.Length; i++)
            {
                leftPiece[i] = input[i];
            }

            int numRight = 0;
            for (int i = leftPiece.Length + centerPiece.Length; i < input.Length; i++)
            {
                rightPiece[numRight] = input[i];
                numRight++;
            }

            int numMid = 0;
            for (int i = leftPiece.Length; i < leftPiece.Length + centerPiece.Length; i++)
            {
                centerPiece[numMid] = input[i];
                numMid++;
            }
        }
    }
}
