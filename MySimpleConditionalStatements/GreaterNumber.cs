using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
			//Input 2 numbers find the Greater Number and print it
			
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int result = 0;

            if (numA > numB) result = numA;
            else if (numA < numB) result = numB;
            else if (numA == numB) result = numA;

            Console.WriteLine(result);
        }
    }
}