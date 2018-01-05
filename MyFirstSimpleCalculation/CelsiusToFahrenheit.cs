using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
		// Input 2 degrees in Celsius convert it in Fahrenheit and print c in Fahrenheit
		
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 1.8 + 32;
        Console.WriteLine(Math.Round(fahrenheit,2));
    }
}