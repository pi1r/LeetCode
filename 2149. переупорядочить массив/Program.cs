using System;

namespace _2149.LoveLeetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 86, 3, 4, -1, -2, -3, -4 };

            int[] positiveNum = new int[nums.Length / 2];
            int[] negativeNum = new int[nums.Length / 2];

            int[] empty = new int[nums.Length]; 
            int positiveIndex = 0;
            int negativeIndex = 0;
            int emptyIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    positiveNum[positiveIndex] = nums[i];
                    positiveIndex++;
                }
                else
                {
                    negativeNum[negativeIndex] = nums[i];
                    negativeIndex++;
                }
            }

            for (int i = 0; i < positiveNum.Length; i++)
            {
                empty[emptyIndex] = positiveNum[i];
                emptyIndex += 2;
            }
            emptyIndex = 1;
            for (int i = 0; i < negativeNum.Length; i++)
            {
                empty[emptyIndex] = negativeNum[i];
                emptyIndex += 2;
            }

            Console.WriteLine("Positive");
            for (int i = 0; i < positiveIndex; i++)
            {
                Console.WriteLine(positiveNum[i]);
            }
            Console.WriteLine("Negative");
            for (int i = 0; i < negativeIndex; i++)
            {
                Console.WriteLine(negativeNum[i]);
            }

            Console.WriteLine("RESULT");
            for (int i = 0; i < empty.Length; i++)
            {
                Console.WriteLine(empty[i]);
            }
        }
    }
}
