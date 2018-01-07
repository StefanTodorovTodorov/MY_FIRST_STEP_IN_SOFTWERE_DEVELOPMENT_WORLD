using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int f0 = 0;
            for (int f = 0; f < n; f++)
            {
                f0 = f1 + f2;
                f1 = f2;
                f2 = f0;
            }
            Console.WriteLine(f2);
        }
    }
}