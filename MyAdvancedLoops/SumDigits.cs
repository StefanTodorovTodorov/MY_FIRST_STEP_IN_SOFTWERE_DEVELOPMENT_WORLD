using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
			//Input number. Take every digit in the number. Assemble value of all digits and print the sum of all
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            do
            {
                num += n % 10;
                n = n / 10;
            } while (n>0);
            Console.WriteLine(num);
        }
    }
}