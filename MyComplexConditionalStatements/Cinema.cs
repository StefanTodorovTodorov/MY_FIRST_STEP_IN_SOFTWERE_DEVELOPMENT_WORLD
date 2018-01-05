using System;

class Cinema
{
    static void Main()
    {
		/*Input projection type and rows and columns count.
		Calculate total ticket sales value and print it in "leva"*/
		
        string type = Console.ReadLine().ToLower();
        int columns = int.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        decimal result = columns*rows;

        switch (type)
        {
            case "premiere":
                result *= 12.00m;
                break;
            case "normal":
                result *= 7.50m;
                break;
            case "discount":
                result*=5.00m;
                break;
        }
                Console.WriteLine($"{result:f2} leva");
    }
}