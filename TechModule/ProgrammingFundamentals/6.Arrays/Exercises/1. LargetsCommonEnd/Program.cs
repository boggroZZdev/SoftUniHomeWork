using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LargetsCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();
            int min = Math.Min(arrayOne.Length, arrayTwo.Length);
            int max = Math.Max(arrayOne.Length, arrayTwo.Length);
            int leftSum = 0;
            int rightSum = 0;
            int difference = max - min;

            for (int i = 0; i < min; i++)
            {
                if (arrayOne[i]==arrayTwo[i])
                {
                    leftSum++;
                }
            }

            for (int i = min-1; i >= 0; i--)
            {
                if (arrayOne.Length>arrayTwo.Length)
                {
                    if (arrayOne[i+difference] == arrayTwo[i])
                    {
                        rightSum++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayTwo.Length>arrayOne.Length)
                {                                    
                    if (arrayOne[i] == arrayTwo[i+difference])
                    {
                        rightSum++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        rightSum++;
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            if (leftSum==0&&rightSum==0)
            {
                Console.WriteLine("0");
            }
            else if (leftSum>rightSum)
            {
                Console.WriteLine(leftSum);
            }
            else
            {
                Console.WriteLine(rightSum);
            }
        }
    }
}
