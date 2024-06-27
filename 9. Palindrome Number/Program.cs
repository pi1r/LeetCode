using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Попробуй решить через строчку.
            int x = 121;
            int num = x; 
            int lenth = 0;

            while (x > 0)
            {
                x /= 10;
                lenth++;
            }
            int[] array = new int[lenth];
            int[] arrayRevers = new int[lenth];

            for (int i = 0; i < lenth; i++)
            {
                array[i] = num % 10;
                num /= 10;
                
            }

            int j = 0; 
            for (int i = array.Length-1; i >= 0; i--)
            {
                arrayRevers[j] = array[i];
                j++; 
            }

            bool result = true; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != arrayRevers[i])
                {
                    result = false;
                    break; 
                }
                
              
            }
            Console.WriteLine(result);
        }
    }
}
