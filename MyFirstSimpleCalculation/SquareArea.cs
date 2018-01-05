using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareArea
{
    static void Main(string[] args)
    {
		/*Print message
		Input side "a"
		Calculate area and Print it*/
		
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        int area = a * a;
        Console.WriteLine($"Square = {area}");
    }
}