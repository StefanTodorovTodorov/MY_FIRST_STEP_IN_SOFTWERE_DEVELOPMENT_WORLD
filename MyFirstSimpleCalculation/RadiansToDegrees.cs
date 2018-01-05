using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RadiansToDegrees
{
    static void Main()
    {
		/*Input radians value
		Convert radians in degrees
		Print value in degrees*/
		
        double rad = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double degrees = rad * 180 / pi;
        Console.WriteLine(Math.Round(degrees));
    }
}