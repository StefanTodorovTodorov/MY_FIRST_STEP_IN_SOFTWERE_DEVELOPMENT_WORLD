using System;

class OddOrEvenPosition
{
    static void Main()
    {
		/* Input 'n' number
		Read 'n' number elements
		Find min and max of event and odd numbers
		Calculate total sum of event and odd numbers
		Print max, min and total sum of event and odd numbers*/
		
        int n = int.Parse(Console.ReadLine());
        double minEven = double.MaxValue;
        double maxEven = double.MinValue;
        double sumEven = 0;
        
        double minOdd = double.MaxValue;
        double maxOdd = double.MinValue;
        double sumOdd = 0;


        for (int i = 1; i <= n; i++)
        {
            double input = double.Parse(Console.ReadLine());
            if (i%2==0)
            {
                sumEven += input;
                if (input>maxEven)
                {
                    maxEven = input;
                }
                if (input < minEven)
                {
                    minEven = input;
                }
            }
            else
            {
                sumOdd += input;
                if (input>maxOdd)
                {
                    maxOdd = input;
                }
                if (input<minOdd)
                {
                    minOdd = input;
                }
            }
        }

        Console.WriteLine($"OddSum={sumOdd},");

        if (minOdd==double.MaxValue)
        {
            Console.WriteLine($"OddMin=No,");
        }
        else
        {
            Console.WriteLine($"OddMin={minOdd},");
        }

        if (maxOdd==double.MinValue)
        {
            Console.WriteLine($"OddMax=No,");
        }
        else
        {
            Console.WriteLine($"OddMax={maxOdd},");
        }


        Console.WriteLine($"EvenSum={sumEven},");

        if (minEven == double.MaxValue)
        {
            Console.WriteLine($"EvenMin=No,");
        }
        else
        {
            Console.WriteLine($"EvenMin={minEven},");
        }

        if (maxEven == double.MinValue)
        {
            Console.WriteLine($"EvenMax=No");
        }
        else
        {
            Console.WriteLine($"EvenMax={maxEven}");
        }

    }
}