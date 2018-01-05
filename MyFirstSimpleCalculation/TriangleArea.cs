using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleArea
{
    static void Main(string[] args)
    {
		//Input side a and height h, calculate Area and print it
		
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = Math.Round(a * h / 2, 2);
        Console.WriteLine("Triangle area = {0}",area);
    }
}