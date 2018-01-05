using System;

class InvalidNumber
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        bool validNumber = (input >= 100 && input <= 200) || input == 0;
        if (!validNumber)
        {
            Console.WriteLine("invalid");
        }
    }
}