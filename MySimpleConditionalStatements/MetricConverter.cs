using System;



class MetricConverter
{
    static void Main()
    {
		/* Input measure value and name
		Input converting measure name
		Find converting measure value calculate and print it*/
		
        double value = double.Parse(Console.ReadLine());
        string measureNameA = Console.ReadLine().ToLower();
        string measureNameB = Console.ReadLine().ToLower();
        double measureValueA = 0;
        double measureValueB = 0;
        if (measureNameA == "mm")
        {
            measureValueA = 1000;
        }
        else if (measureNameA == "cm")
        {
            measureValueA = 100;
        }
        else if (measureNameA == "mi")
        {
            measureValueA = 0.000621371192;
        }
        else if (measureNameA == "in")
        {
            measureValueA = 39.3700787;
        }
        else if (measureNameA == "km")
        {
            measureValueA = 0.001;
        }
        else if (measureNameA == "ft")
        {
            measureValueA = 3.2808399;
        }
        else if (measureNameA == "yd")
        {
            measureValueA = 1.0936133;
        }
        else if (measureNameA == "m")
        {
            measureValueA = 1;
        }

        if (measureNameB == "mm")
        {
            measureValueB = 1000;
        }
        else if (measureNameB == "cm")
        {
            measureValueB = 100;
        }
        else if (measureNameB == "mi")
        {
            measureValueB = 0.000621371192;
        }
        else if (measureNameB == "in")
        {
            measureValueB = 39.3700787;
        }
        else if (measureNameB == "km")
        {
            measureValueB = 0.001;
        }
        else if (measureNameB == "ft")
        {
            measureValueB = 3.2808399;
        }
        else if (measureNameB == "yd")
        {
            measureValueB = 1.0936133;
        }
        else if (measureNameB == "m")
        {
            measureValueB =1;
        }
        double convertionValue = (value / measureValueA) * measureValueB;
        Console.WriteLine(convertionValue);
    }
}