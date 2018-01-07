using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int diffPairs = 0;
		
		/*Input 'n' number, input 'n'  pairs value, calculate sum of each one pair.
		If all pairs are equal print message "Yes" and a pair sum
		If pairs are different print message "Different" and difference value*/

        for (int i = 1; i <= n; i++)
        {
            int pairSum = 0;
            for (int j = 0; j < 2; j++)
            {
                int input = int.Parse(Console.ReadLine());
                pairSum += input;
            }
            if (i==1)
            {
                sum = pairSum;
            }
            else
            {
                if (sum != pairSum)
                {
                    if (diffPairs<Math.Abs(sum-pairSum))
                    {
                        diffPairs = Math.Abs(sum - pairSum);
                    }
                    sum = pairSum;
                }
            }
        }

        if (diffPairs == 0)
        {
            Console.WriteLine($"Yes, value={sum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={diffPairs}");
        }

    }
}