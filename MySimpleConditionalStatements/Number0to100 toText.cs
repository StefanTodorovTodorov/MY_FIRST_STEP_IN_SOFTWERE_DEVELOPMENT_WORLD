using System;

class Program
{
    static void Main()
    {
		//Input number from 1 to 100 and print Number Name
		
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int digit = 0;
        string numberName = null;
        string digitName = null;
        string output = null;
        if (n>=0&&n<20)
        {
            digit = n;
        }
        else if (n>=20&&n<=100)
        {
            digit = n % 10;
            number = n - digit;
        }
        if (number>=20&&number<=100)
        {
            
            if (number==20)
            {
                numberName = "twenty";
            }
            else if (number == 30)
            {
                numberName = "thirty";
            }
            else if (number == 40)
            {
                numberName = "forty";
            }
            else if (number == 50)
            {
                numberName = "fifty";
            }
            else if (number == 60)
            {
                numberName = "sixty";
            }
            else if (number == 70)
            {
                numberName = "seventy";
            }
            else if (number == 80)
            {
                numberName = "eighty";
            }
            else if (number == 90)
            {
                numberName = "ninety";
            }
            else if (number == 100)
            {
                numberName = "one hundred";
            }
        }
        if (digit>=0 && digit<20)
        {
            if (digit==0)
            {
                digitName = "zero";
            }
            else if (digit == 1)
            {
                digitName = "one";
            }
            else if (digit == 2)
            {
                digitName = "two";
            }
            else if (digit == 3)
            {
                digitName = "three";
            }
            else if (digit == 4)
            {
                digitName = "four";
            }
            else if (digit == 5)
            {
                digitName = "five";
            }
            else if (digit == 6)
            {
                digitName = "six";
            }
            else if (digit == 7)
            {
                digitName = "seven";
            }
            else if (digit == 8)
            {
                digitName = "eight";
            }
            else if (digit == 9)
            {
                digitName = "nine";
            }
            else if (digit == 10)
            {
                digitName = "ten";
            }
            else if (digit == 11)
            {
                digitName = "eleven";
            }
            else if (digit == 12)
            {
                digitName = "twelve";
            }
            else if (digit == 13)
            {
                digitName = "thirteen";
            }
            else if (digit == 14)
            {
                digitName = "fourteen";
            }
            else if (digit == 15)
            {
                digitName = "fifteen";
            }
            else if (digit == 16)
            {
                digitName = "sixteen";
            }
            else if (digit == 17)
            {
                digitName = "seventeen";
            }
            else if (digit == 18)
            {
                digitName = "eighteen";
            }
            else if (digit == 19)
            {
                digitName = "nineteen";
            }
        }
        if (n>=20&&n<=100)
        {
            if (digitName=="zero")
            {
                output = numberName;
            }
            else
            {
                output = $"{numberName} {digitName}";
            }
        }
        else if (n>=0&&n<20)
        {
            output = digitName;
        }
        else
        {
            output = "invalid number";
        }
        Console.WriteLine(output);
        
    }
}