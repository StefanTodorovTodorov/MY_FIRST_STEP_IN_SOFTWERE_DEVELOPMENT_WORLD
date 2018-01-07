using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftRight = (n - 1) / 2;

        if (n > 2 && n <= 100)
        {
            if (n % 2 == 1)
            {
                Console.WriteLine($"{new string('-', leftRight)}*{new string('-', leftRight)}");
            }

            for (int row = 2; row <= n; row++)
            {
                if (row % 2 == n % 2)
                {
                    Console.WriteLine($"{new string('-', (n - row) / 2)}*{new string('-', row - 2)}*{new string('-', (n - row) / 2)}");
                }
            }
            for (int row = n-1; row >= 2; row--)
            {
                if (row % 2 == n % 2)
                {
                    Console.WriteLine($"{new string('-', (n - row) / 2)}*{new string('-', row - 2)}*{new string('-', (n - row) / 2)}");
                }
            }

            if (n % 2 == 1)
            {
                Console.WriteLine($"{new string('-', leftRight)}*{new string('-', leftRight)}");
            }
        }
        else if(n>=1&&n<=2)
        {
            Console.WriteLine(new string('*',n));
        }
    }
}