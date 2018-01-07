using System;

class HalfSumElement
{
    static void Main()
    {
		/*Input 'n' number
		Read 'n' count, number elements
		If one of this elements is equal on the sum of all elements 
		print message "Yes" and an element value
		If no one of elements is not equal of all sum of elements, print message "No Diff" 
		and difference betwen the bigger element and the sum of all*/ 
		
		
        int n = int.Parse(Console.ReadLine());
        int maxNum = int.MinValue;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input>maxNum)
            {
                maxNum = input;
            }
            sum += input;
        }
        sum = Math.Abs(sum - maxNum);
        if (maxNum == sum)
        {
            Console.WriteLine($"Yes Sum = {maxNum}");
        }
        else
        {
            sum = Math.Abs(sum - maxNum);
            Console.WriteLine($"No Diff = {sum}");

        }
    }
}