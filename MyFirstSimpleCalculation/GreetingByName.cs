using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreetingByName
{
    static void Main(string[] args)
    {
		//Print message, Input Name and Print greeting
		
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",name);
    }
}