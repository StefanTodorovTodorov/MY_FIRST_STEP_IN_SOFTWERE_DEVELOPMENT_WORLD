using System;

class DrawFort
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        char ch = '_';

        if (n >= 3 && n <= 1000)
        {
            Console.WriteLine($"/{new string('^', n / 2)}\\{new string('_', ((n * 2) - (((n / 2) * 2)) - 4))}/{new string('^', n / 2)}\\");
            for (int row = 1; row <= n - 2; row++)
            {
                if (row == n - 2)
                {
                    ch = '_';
                }
                else
                {
                    ch = ' ';
                }
                Console.WriteLine($"|{new string(' ', n / 2)} {new string(ch, ((n * 2) - (((n / 2) * 2)) - 4))} {new string(' ', n / 2)}|");
            }
            Console.WriteLine($"\\{new string('_', n / 2)}/{new string(' ', ((n * 2) - (((n / 2) * 2)) - 4))}\\{new string('_', n / 2)}/");
        }
    }
}