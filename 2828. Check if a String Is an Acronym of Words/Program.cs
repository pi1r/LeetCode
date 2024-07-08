using System;


namespace _2828.Check_if_a_String_Is_an_Acronym_of_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "pple", "banana", "combo",  "ппа" };
            string str = "abc";
            int c = 0;
          
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i][c] == str[i])
                {
                    continue; 
                }
                else
                {
                    Console.WriteLine("нет");
                    break;
                }
            }
            Console.WriteLine("есть"); 

        }
    }
}
