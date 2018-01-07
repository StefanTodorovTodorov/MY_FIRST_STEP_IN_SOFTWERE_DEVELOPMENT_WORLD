using System;


class LeftAndRightSum
{
    static void Main()
    {
		/*Input 'n' number
		Read 'n' x 2 pairs. They are left and right pairs
		If the sum of left pair is equal on the sum of right pair
		Print message "Yes" and sum of a pair
		If	pairs are different print "No ,diff" and difference betwen
		left and right pairs*/
		
        int n = int.Parse(Console.ReadLine());
        int nX2 = n * 2;
        int leftSum = 0;
        int rightSum = 0;
        int sum = 0;
        for (int i = 1; i <= nX2; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (i<=n)
            {
                rightSum += input;
            }
            else
            {
                leftSum += input;
            }
        }
        sum = Math.Abs(rightSum - leftSum);

        if (sum==0)
        {
            Console.WriteLine($"Yes, sum = {rightSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {sum}");
        }
    }
}