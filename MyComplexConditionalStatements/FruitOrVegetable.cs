using System;

class FruitOrVegetable
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        bool fruit = input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes";
        bool vegetable = input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot";

        if (fruit)
        {
            Console.WriteLine("fruit");
        }
        else if (vegetable)
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}