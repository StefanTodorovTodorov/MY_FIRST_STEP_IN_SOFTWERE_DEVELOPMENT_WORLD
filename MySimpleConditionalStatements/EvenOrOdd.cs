using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EvenOrOdd
{
    static void Main()
    {
		/* Input number
		If number is even print "even" message
		If number is odd print "odd" message */
		
        int n = int.Parse(Console.ReadLine());
        string info = null;
        if (n % 2 == 0)
        {
            info = "even";
        }
        else
        {
            info = "odd";
        }
        Console.WriteLine(info);
    }
}