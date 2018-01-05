using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
			//Input radius, calculate area and perimeter and print results
			
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * r * r;
            double perimeter = 2 * pi * r;
            Console.WriteLine("Area = {0}",area);
            Console.WriteLine("Perimeter = {0}",perimeter);
        }
    }
}