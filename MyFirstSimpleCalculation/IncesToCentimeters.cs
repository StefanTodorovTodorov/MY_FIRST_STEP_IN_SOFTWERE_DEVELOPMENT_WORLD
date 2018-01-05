using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IncesToCentimeters
{
    static void Main(string[] args)
    {
		/*Print the message 
		Input inches value
		Convert inches to centimeters
		Print converting name and value*/
		
        Console.Write("inches = ");
        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;
        Console.WriteLine($"centimeters = {centimeters}");
    }
}