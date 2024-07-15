using Microsoft.Win32.SafeHandles;
using System;

class Program
{
    static void Main()
    {
        int[] nums = { 0, 2, 1, 1, 2, 2 };

        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    for (int j = 0; j < nums.Length - 1 - i; j++)
        //    {
        //        if (nums[j] > nums[j + 1])
        //        {
        //            int temp = nums[j];
        //            nums[j] = nums[j + 1];
        //            nums[j + 1] = temp;
        //        }
        //    }
        //}

        int zero = 0;
        int one = 0;
        int two = 0;    
        for (int i = 0; i<nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zero++;
            }
            if (nums[i] == 1)
            {
                one++;
            }
            if (nums[i] == 2){
                two++; 
            }
           
        }
        for (int j = 0; j < nums.Length; j++)
        {
            if (zero != 0)
            {
                nums[j] = 0;
                zero--;
            }

            else if (zero == 0 && one != 0)
            {
                nums[j] = 1;
                one--;
            }
            else if (zero == 0 && one == 0 && two != 0)
            {
                nums[j] = 2;
            }
        }
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
}