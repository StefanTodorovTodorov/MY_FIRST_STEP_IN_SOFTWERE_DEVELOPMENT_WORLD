using System;

class Histogram
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        double oneNum = 0;
        double twoHundredNum = 0;
        double fourHundredNum = 0;
        double sixHundredNum = 0;
        double eightHundredNum = 0;

        if (n >= 1 && n <= 1000)
        {
            for (short i = 1; i <= n; i++)
            {
                short input = short.Parse(Console.ReadLine());
                if (input >= 1 && input < 200)
                {
                    oneNum++;
                }
                else if (input >= 200 && input <= 399)
                {
                    twoHundredNum++;
                }
                else if (input >= 400 && input <= 599)
                {
                    fourHundredNum++;
                }
                else if (input >= 600 && input <= 799)
                {
                    sixHundredNum++;
                }
                else if (input >= 800)
                {
                    eightHundredNum++;
                }

            }
        }
        Console.WriteLine($"{(oneNum / n * 100):f2}%");
        Console.WriteLine($"{(twoHundredNum / n * 100):f2}%");
        Console.WriteLine($"{(fourHundredNum / n * 100):f2}%");
        Console.WriteLine($"{(sixHundredNum / n* 100):f2}%");
        Console.WriteLine($"{(eightHundredNum / n* 100):f2}%");
    }
}