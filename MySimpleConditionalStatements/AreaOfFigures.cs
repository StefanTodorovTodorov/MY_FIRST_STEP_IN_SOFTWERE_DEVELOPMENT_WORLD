using System;

class AreaOfFigures
{
    static void Main()
    {
		//Input figure Name, calculate Area and print it
		
        string fig = Console.ReadLine().ToLower();
        double area = 0;
        if (fig == "square")
        {
            double value = double.Parse(Console.ReadLine());
            area = value;
            area *= value;
        }
        else if (fig== "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            area = a * b;
        }
        else if (fig== "circle")
        {
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            area = r * r * pi;
        }
        else if (fig== "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            area = (a * h) / 2;
        }
        Console.WriteLine(Math.Round(area,3));
    }
}