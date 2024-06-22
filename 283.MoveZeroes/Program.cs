using System;

namespace MoveZero
{
    class Programm
    {
        static void Main(string[] args)
        {


            int[] nums = { 1, 0, 2 };
            int startArr = 0;
            int endArr = nums.Length - 1;
            while (startArr < endArr)
            {

                if (nums[startArr] == 0)
                {
                    for (int i = startArr; i < endArr; i++)
                    {
                        //Обмен значениями
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                    endArr--;
                }
                else
                {
                    startArr++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}