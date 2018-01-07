using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = ((4 * n + 1) - 3)/2;
            Console.WriteLine($"{new string('.',leftRight)}/|\\{new string('.', leftRight)}");
            Console.WriteLine($"{new string('.',leftRight)}\\|/{new string('.', leftRight)}");

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine($"{new string('.', leftRight)}*{new string('.',i)}*{new string('.', i)}*{new string('.', leftRight)}");
                leftRight--;
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < (4*n+1); i++)
            {
                if (i%2==0)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
