using System;
using System.Reflection.Metadata;

namespace LeetCode
{
    class Programm
    {
        static void Main(string[] args)
        {

            string[] strs = { "flower", "flow", "flight" };

            string shortestString = strs[0];
            string result = ""; 
            foreach (string str in strs)
            {
                if (str.Length < shortestString.Length)
                {
                    shortestString = str;
                }
            }

            for (int j = 0; j < shortestString.Length;j++)
            {
                char c = shortestString[j]; 
                for (int i = 0; i < strs.Length; i++)
                {
                    if (j >= strs[i].Length || strs[i][j] !=c )
                    {
                        Console.WriteLine(result);
                        return;
                    }
                }
                result = result + c;
            }
            Console.WriteLine(result);
        }
    }
}