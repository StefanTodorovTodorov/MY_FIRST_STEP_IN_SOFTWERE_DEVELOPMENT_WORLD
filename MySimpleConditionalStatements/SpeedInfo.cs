﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpeedInfo
{
    static void Main()
    {
		//Input speed end print the message "slow","average","fast","ultra fast" and "extremely fast"
		
        double speed = double.Parse(Console.ReadLine());
        if (speed<=10)
        {
            Console.WriteLine("slow");
        }
        else if (speed>10 && speed<=50)
        {
            Console.WriteLine("average");
        }
        else if (speed>50 && speed<=150)
        {
            Console.WriteLine("fast");
        }
        else if (speed>150 && speed<=1000)
        {
            Console.WriteLine("ultra fast");
        }
        else if (speed>1000)
        {
            Console.WriteLine("extremely fast");
        }
    }
}