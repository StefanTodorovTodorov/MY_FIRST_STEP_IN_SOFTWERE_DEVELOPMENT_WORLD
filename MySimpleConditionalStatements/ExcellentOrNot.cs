using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExcellentOrNot
{
    static void Main()
    {
		/*Input the evaluation , if it is greater then 5.50 print "Excellent!".
		If it is less print "Not excellent."*/
			
        double n = double.Parse(Console.ReadLine());
        if (n >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}
