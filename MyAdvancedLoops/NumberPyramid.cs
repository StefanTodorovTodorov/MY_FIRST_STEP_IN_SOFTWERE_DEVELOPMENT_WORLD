using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
			//Input number and print Pyramid of numbers
			
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col>1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(counter);
                    counter++;
                    if (counter>n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (counter>n)
                {
                    break;
                }
            }
        }
    }
}