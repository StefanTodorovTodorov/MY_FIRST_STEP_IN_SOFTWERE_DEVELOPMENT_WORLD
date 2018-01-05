using System;

class AnimalType
{
    static void Main()
    {
        string enimal = Console.ReadLine().ToLower();
        switch (enimal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}