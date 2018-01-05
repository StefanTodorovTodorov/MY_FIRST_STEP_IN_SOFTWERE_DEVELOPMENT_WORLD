using System;

class TreeEqualNumbers
{
    static void Main()
    {
		//Input 3 real numbers. If they are equal print "yes". If they are not equal print "no"
		
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (b==a && c==a)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}