using System;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <=n; row++)
        {
            Console.Write(new string(' ',n-row));
            Console.Write('*');

            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        for (int row = n-1; row >= 1; row--)
        {
            Console.Write(new string(' ', n - row));
            Console.Write('*');

            for (int col = row-1; col >= 1; col--)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}