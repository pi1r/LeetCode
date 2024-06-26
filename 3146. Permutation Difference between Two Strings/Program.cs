using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3146.Permutation_Difference_between_Two_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcde";
            string t = "edbac";

            int sIndex = 0; 
            int tIndex = 0;


            int para = 0; 
            int result = 0; 
            char[] sArray = s.ToCharArray();
            char[] tArray= t.ToCharArray();


            for (int i = 0; i < sArray.Length; i++)
            {
                sIndex = i; 
                for (int j = 0; j < tArray.Length; j++)
                {
                    if (sArray[i] == tArray[j])
                    {
                        tIndex = j;
                    }
                    else
                    {
                        continue; 
                    }

                    
                }

                para = Math.Abs(sIndex - tIndex);
                result = para + result;
            }
            
            Console.WriteLine(result);
        }
    }
}
