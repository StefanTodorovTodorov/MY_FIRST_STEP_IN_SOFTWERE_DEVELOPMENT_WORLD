using System;

class TransportPrice
{
    static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string period = Console.ReadLine().ToLower();
        double sum = 0.00;

        if (km >= 0 && km <20)
        {
            if (period == "day")
            {
                sum = 0.7 + (km * 0.79);
            }
            else if (period == "night")
            {
                sum = 0.7 + (km * 0.9);
            }
        }
        else if (km >= 20 && km < 100)
        {
            sum = km * 0.09;
        }
        else if (km >= 100)
        {
            sum = km * 0.06;
        }
        Console.WriteLine(sum);
    }
}