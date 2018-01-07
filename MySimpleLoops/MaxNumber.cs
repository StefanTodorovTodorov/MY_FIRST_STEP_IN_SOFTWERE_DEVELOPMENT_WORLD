using System;


class MaxNumber
{
    static void Main()
    {
		/*Input 'n' number
		Read 'n' numbers 
		Print the largest number of all*/
		
        int n = int.Parse(Console.ReadLine());
        int bigNum = int.MinValue;
        for (int i = 1; i <= n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input>bigNum)
            {
                bigNum = input;
            }
        }
        Console.WriteLine(bigNum);
    }
}