using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*',n));
        for (int i = 1; i <= n-2; i++)
        {
            Console.Write("*");
            Console.Write(new string(' ',n-2));
            Console.WriteLine("*");
        }
        Console.WriteLine(new string('*',n));
    }
}