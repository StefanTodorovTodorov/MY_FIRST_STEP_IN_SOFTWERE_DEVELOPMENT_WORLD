using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double moneyInheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            byte age = 18;

            for (int y = 1800; y <= year; y++)
            {
                if (y%2 != 0)
                {
                    moneyInheritance = moneyInheritance - (12000 + (50 * age));
                }
                else
                {
                    moneyInheritance = moneyInheritance - 12000;
                }
                age++;
            }
            if (moneyInheritance<0)
            {
                moneyInheritance = moneyInheritance * -1;
                Console.WriteLine($"He will need {moneyInheritance:f2} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInheritance:f2} dollars left.");
            }
        }
    }
}