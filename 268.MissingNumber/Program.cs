using System;

class Programm
{
    static void Main(string[] args)
    {
        int[] num = {0,3,1};
        int n = num.Length;
        int waitSum = n * (n + 1) / 2;
        int factSum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            factSum += num[i];
        }

        int result = waitSum - factSum;

        Console.WriteLine(result);
    }
}