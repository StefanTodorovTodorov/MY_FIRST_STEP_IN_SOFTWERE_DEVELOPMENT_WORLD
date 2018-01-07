using System;

class SquareFrame
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char ch = ' ';
        for (int row = 0; row < n; row++)
        {
            if (row == 0 || row == n-1)
            {
                ch = '+';
            }
            else
            {
                ch = '|';
            }

            Console.Write(ch);
            for (int col = 0; col < n-2; col++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" "+ch);
        }
    }
}