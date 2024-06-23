using System;

namespace MoveZero
{
    class Programm
    {
        static void Main(string[] args)
        {

            int[] pref = { 13 };
            int[] arr = new int[pref.Length];
            arr[0] = pref[0];

            for (int i = 1; i < pref.Length; i++)
            {
                arr[i] = pref[i] ^ pref[i - 1];
            }
            Console.WriteLine(string.Join(", ", arr));

        }
    }
}