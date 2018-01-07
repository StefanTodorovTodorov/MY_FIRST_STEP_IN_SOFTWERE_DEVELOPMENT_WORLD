using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.',n));
            Console.Write(new string('*', (5 * n) - (2 * n)));
            Console.WriteLine(new string('.',n));

            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(new string('.',i)+"*");
                Console.Write(new string('.',((5*n)-(2*i))-2));
                Console.WriteLine("*"+ new string('.',i));
            }

            Console.WriteLine(new string('*',5*n));

            for (int i = 1; i <= ((3*n+2)-(n+1)); i++)
            {
                Console.Write(new string('.',i) + "*");
                if (i == ((3 * n + 2) - (n + 1)))
                {
                    Console.Write(new string('*', ((5 * n) - (i * 2)) - 2));
                }
                else
                {
                    Console.Write(new string('.',((5*n)-(i*2))-2));
                }
                Console.WriteLine("*" + new string('.',i));
            }
        }
    }
}