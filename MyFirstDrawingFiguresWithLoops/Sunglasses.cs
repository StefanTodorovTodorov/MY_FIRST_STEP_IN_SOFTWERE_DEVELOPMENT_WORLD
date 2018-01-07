using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int w = (((n * 5) - n) / 2)-2;
        int midBorder = ((n - 1) / 2) - 1;
        char ch = '|';

        if (n >= 3 && n <= 100)
        {
            Console.WriteLine($"*{new string('*', w)}*{new string(' ', n)}*{new string('*', w)}*");
            for (int row = 0; row < n - 2; row++)
            {
                if (row != midBorder)
                {
                    ch = ' ';
                }
                else if (row == midBorder)
                {
                    ch = '|';
                }

                Console.WriteLine($"*{new string('/', w)}*{new string(ch, n)}*{new string('/', w)}*");
            }
            Console.WriteLine($"*{new string('*', w)}*{new string(' ', n)}*{new string('*', w)}*");
        }
    }
}