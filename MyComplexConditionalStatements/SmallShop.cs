using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SmallShop
{
    static void Main()
    {
		/*Input product, city name, qty and print 
		how much does it cost in the city*/
		
        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToUpper();
        double qty = double.Parse(Console.ReadLine());
        double price = 0;

        if (city == "SOFIA")
        {
            if (product == "coffee")
            {
                price = 0.50;
            }
            else if (product == "water")
            {
                price = 0.80;
            }
            else if (product == "beer")
            {
                price = 1.20;
            }
            else if (product == "sweets")
            {
                price = 1.45;
            }
            else if (product == "peanuts")
            {
                price = 1.60;
            }
        }

        else if (city == "PLOVDIV")
        {
            if (product == "coffee")
            {
                price = 0.40;
            }
            else if (product == "water")
            {
                price = 0.70;
            }
            else if (product == "beer")
            {
                price = 1.15;
            }
            else if (product == "sweets")
            {
                price = 1.30;
            }
            else if (product == "peanuts")
            {
                price = 1.50;
            }
        }

        else if (city == "VARNA")
        {
            if (product == "coffee")
            {
                price = 0.45;
            }
            else if (product == "water")
            {
                price = 0.70;
            }
            else if (product == "beer")
            {
                price = 1.10;
            }
            else if (product == "sweets")
            {
                price = 1.35;
            }
            else if (product == "peanuts")
            {
                price = 1.55;
            }
        }
        price *= qty;
        Console.WriteLine(price);
    }
}