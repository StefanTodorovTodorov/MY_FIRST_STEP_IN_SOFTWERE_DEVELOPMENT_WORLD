using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class usdToBgn
{
    static void Main()
    {
		//Input USD value, convert it in BGN value and print it
		
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal bgn = 1.79549m;
        decimal bgnSum = usd * bgn;
        Console.WriteLine($"{bgnSum:f2} BGN");
    }
}