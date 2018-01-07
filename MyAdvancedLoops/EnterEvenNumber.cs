using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
			/*Input number
			If number isn't event number or it is other
			input while it be event number
			If the number is event print message*/
			
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}