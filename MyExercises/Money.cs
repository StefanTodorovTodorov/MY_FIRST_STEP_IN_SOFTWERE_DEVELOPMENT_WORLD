using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            double bgnUsd = 1.76;
            double eur = 1.95;

            bitcoin = bitcoin * 1168;
            yuan = yuan * 0.15;
            bgnUsd = bgnUsd * yuan;
            eur = (bitcoin + bgnUsd)/eur;
            eur = eur - (eur * (commission / 100));
            Console.WriteLine($"{eur:f2}");
        }
    }
}