using System;

class MinNumber
{
    static void Main()
    {
		/*Input 'n' number
		Read 'n' numbers 
		Print at least number of all*/
		
        int n = int.Parse(Console.ReadLine());
        int bigNum = int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < bigNum)
            {
                bigNum = input;
            }
        }
        Console.WriteLine(bigNum);
    }
}