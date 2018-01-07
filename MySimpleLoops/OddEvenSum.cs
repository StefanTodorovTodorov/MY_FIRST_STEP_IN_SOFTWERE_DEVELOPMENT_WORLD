using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int sumA = 0;
        int sumB = 0;
		
		/*Input number 'n'
		Read 'n' number elements
		Calculate total sum of event numbers and total sum of odd numbers
		If sum of event numbers is equal then sum of odd numbers print "Yes Sum = " and sum
		If sum of event and odd numbers are different print "No Diff = " and the difference */
		
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (i%2==0)
            {
                sumA += input;
            }
            else
            {
                sumB += input;
            }
        }
        sum = Math.Abs(sumA - sumB);
        if (sum ==0)
        {
            Console.WriteLine($"Yes Sum = {sumA}");
        }
        else
        {
            Console.WriteLine($"No Diff = {sum}");
        }
    }
}