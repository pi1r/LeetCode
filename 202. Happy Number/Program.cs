using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number = 234;
        bool isHappy = IsHappy(number);
        Console.WriteLine($"Число {number} счастливо: {isHappy}");
    }

    public static bool IsHappy(int n)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        while (n != 1 && !seenNumbers.Contains(n))
        {
            seenNumbers.Add(n);
            n = GetNext(n);
        }

        return n == 1;
    }

    private static int GetNext(int n)
    {
        int totalSum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            n = n / 10;
            totalSum += digit * digit;
        }
        return totalSum;
    }
}
