﻿using System;

class SumNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine(sum);
    }
}