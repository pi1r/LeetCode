using System;


class Program
{
    static void Main()
    {

        string str = "hello";
        int para = 0; 
        int result = 0;

        for (int i = 0; i < str.Length - 1; i++)
        {
            char c = str[i];
            char next = str[i + 1]; 
            para = Math.Abs((int)c - (int)next);
            result = para + result;
        }

        Console.WriteLine(result);

    }
}
