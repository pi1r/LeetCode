using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929.Concatenation_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 2 };
            int[] ans = new int [nums.Length * 2]; 

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];    
            }

            for(int i = 0; i < nums.Length; i++)
            {
                ans[nums.Length + i] = nums[i]; 
            }

            for (int i = 0;i<ans.Length; i++)
            {

                Console.WriteLine(ans[i]);
            }
        }
    }
}
