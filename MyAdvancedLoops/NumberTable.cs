﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {                
                    num = row + col + 1;
                    if (num>n)
                    {
                        num = (2 * n) - num;
                    }
                    if (col>0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}