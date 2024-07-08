using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _771.Jewels_and_Stones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string money = "z";
            string myWallet = "Z";
            int result = 0; 

            for (int i= 0; i< money.Length; i++)
            {
                for (int j= 0; j<myWallet.Length; j++)
                {
                    if(money[i] == myWallet[j])
                    {
                        result++;
                    }
                }
            }
            
            Console.WriteLine(result);


        }
    }
}
