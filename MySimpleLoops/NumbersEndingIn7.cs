using System;

class NumbersEndingIn7
{
    static void Main()
    {
        for (int i = 0; i <= 1000; i++)
        {
            int num = i;
            if (num % 10 == 7)
            {            
                Console.WriteLine(i);
            }
        }
    }
}