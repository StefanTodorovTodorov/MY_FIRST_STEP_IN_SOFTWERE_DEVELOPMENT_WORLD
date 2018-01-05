using System;

class Program
{
    static void Main()
    {
		//Input number and print "Less", "Between" or "Greater"
		
        int n = int.Parse(Console.ReadLine());
        if (n<100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (n>=100 && n<=200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else if (n>200)
        {
            Console.WriteLine("Greater than 200");
        }
    }
}