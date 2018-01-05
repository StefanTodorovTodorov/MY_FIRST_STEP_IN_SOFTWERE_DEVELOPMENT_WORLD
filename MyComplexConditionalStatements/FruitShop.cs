using System;

class FruitShop
{
    static void Main()
    {
		/* Input fruit name, day name, fruit qty.
		Calculate how much does it cost in weekend or in week and print it*/
		
        string fruit = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double qty = double.Parse(Console.ReadLine());
        double price = -1;

        bool week = day == "monday"||day== "tuesday" || day == "wednesday" || day == "thursday" || day == "friday";
        bool weekend = day == "saturday" || day == "sunday";

        if (week)
        {
            switch (fruit)
            {
                case "banana":
                    price = 2.50;
                    break;
                case "apple":
                    price = 1.20;
                    break;
                case "orange":
                    price = 0.85;
                    break;
                case "grapefruit":
                    price = 1.45;
                    break;
                case "kiwi":
                    price = 2.70;
                    break;
                case "pineapple":
                    price = 5.50;
                    break;
                case "grapes":
                    price = 3.85;
                    break;
            }
        }
        else if (weekend)
        {
            switch (fruit)
            {
                case "banana":
                    price = 2.70;
                    break;
                case "apple":
                    price = 1.25;
                    break;
                case "orange":
                    price = 0.90;
                    break;
                case "grapefruit":
                    price = 1.60;
                    break;
                case "kiwi":
                    price = 3.00;
                    break;
                case "pineapple":
                    price = 5.60;
                    break;
                case "grapes":
                    price = 4.20;
                    break;
            }
        }
        price*=qty;
        if ((week || weekend) && price>0)
        {
            Console.WriteLine($"{price:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}