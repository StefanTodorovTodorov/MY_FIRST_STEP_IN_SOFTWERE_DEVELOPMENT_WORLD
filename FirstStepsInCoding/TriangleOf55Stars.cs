﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleOf55Stars
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
                Console.WriteLine();

        }
    }
}