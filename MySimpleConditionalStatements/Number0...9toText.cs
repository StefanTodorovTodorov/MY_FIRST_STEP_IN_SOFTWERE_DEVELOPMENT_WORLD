using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
		//Input number and print number Name
		
        byte n = byte.Parse(Console.ReadLine());
        string numName = null;
        if (n == 0) 
		{
			numName = "zero";
		}
        else if (n == 1) 
		{
			numName = "one";
		}
        else if (n == 2) 
		{
			numName = "two";
		}
        else if (n == 3) 
		{
			numName = "three";
		}
        else if (n == 4) 
		{
			numName = "four";
		}
        else if (n == 5) 
		{
			numName = "five";
		}
        else if (n == 6) 
		{
			numName = "six";
		}
        else if (n == 7) 
		{
			numName = "seven";
		}
        else if (n == 8) 
		{
			numName = "eight";
		}
        else if (n == 9) 
		{
			numName = "nine";
		}
        else 
		{
			numName = "number too big";
		}
        Console.WriteLine(numName);
    }
}