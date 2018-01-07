using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int roofRowSize = (n + 1) / 2;
        int colRoof = 1;

        if (n >= 2 && n <= 100)
        {

            if (n % 2 == 0)
            {
                colRoof = 2;
            }
            else
            {
                colRoof = 1;
            }

            for (int rowRoof = 1; rowRoof <= roofRowSize; rowRoof++)
            {
                Console.WriteLine($"{new string('-', (n - colRoof) / 2)}{new string('*', colRoof)}{new string('-', (n - colRoof) / 2)}");
                colRoof += 2;
            }

            for (int rowBase = 0; rowBase < n - roofRowSize; rowBase++)
            {
                Console.WriteLine($"{'|'}{new string('*', n - 2)}{'|'}");
            }
        }
    }
}