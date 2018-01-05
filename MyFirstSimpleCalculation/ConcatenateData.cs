using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConcatenateData
{
    static void Main(string[] args)
    {
		/*Input first and last names, age and town, 
		concatenate them in a text and print result*/
		
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        string town = Console.ReadLine();
        Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
    }
}