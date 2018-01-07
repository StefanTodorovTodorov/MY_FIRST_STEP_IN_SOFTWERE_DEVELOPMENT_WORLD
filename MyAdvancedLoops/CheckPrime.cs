using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class CheckPrime
    {
		//Input number check for prime number and print "Prime" if it is prime or print "Not Prime" if it isn't
		
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;


            for (int x = 2; x <= Math.Sqrt(n); x++)
            {
                if (n % x == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (n>=2 && isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}