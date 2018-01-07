using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine('*');
        }
        else if(n>1)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write('*');
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" *");
            }
        }
    }
}