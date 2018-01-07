using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factoriel = n;

            if (n <= 12)
            {
                while (n > 1)
                {
                    n--;
                    factoriel *= n;
                }
                Console.WriteLine(factoriel);
            }
        }
    }
}
