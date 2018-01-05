using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
		/* Input 4 real numbers, calculate area and perimeter
		and print area and perimeter results*/
		
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double a = 0;
        double b = 0;
		
		//Find the bigger numbers
        if (x2 > x1) 
		{
			a = x2 - x1;
		}
        else if (x1 > x2) 
		{
			a = x1 - x2;
		}
        else if (y2 > y1) 
		{
			b = y2 - y1;
		}
        else if (y1 > y2) 
		{
			b = y1 - y2;
		}
		
		//Calculate area and perimeter
        double area = a * b;
        double perim = (a + b) * 2;
		
		//Print area and perimeter results
        Console.WriteLine(area);
        Console.WriteLine(perim);
    }
}