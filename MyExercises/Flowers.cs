using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int flowersH = 2;// int.Parse(Console.ReadLine());
            int flowersR = 4;// int.Parse(Console.ReadLine());
            int flowersL = 8;//int.Parse(Console.ReadLine());

            string season = Console.ReadLine().ToLower();

            decimal sumH = 0m;
            decimal sumL = 0m;
            decimal sumR = 0m;
            decimal sum = 0m;

            if (season == "spring" || season == "summer")
            {
                sumH = sumH + (flowersH * 2m);
                sumR = sumR + (flowersR * 4.1m);
                sumL = sumL + (flowersL * 2.5m);
            }
            else if (season == "winter" || season == "autumn")
            {
                sumH = sumH + (flowersH * 3.75m);
                sumR = sumR + (flowersR * 4.5m);
                sumL = sumL + (flowersL * 4.15m);
            }

            if (flowersR>=10)
            {
                sumR = sumR - (sumR * 0.1m);
            }
            else if (flowersL >=7)
            {
                sumL = sumL - (sumL * 0.05m);
            }
            else if (flowersH+flowersL+flowersR>=20)
            {

            }
           
        }
    }
}
