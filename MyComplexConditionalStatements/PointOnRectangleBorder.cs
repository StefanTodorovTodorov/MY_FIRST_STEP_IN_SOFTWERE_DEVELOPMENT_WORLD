using System;

class PointOnRectangleBorder
{
    static void Main()
    {
		/*Input rectangle border (x1,y1,x2,y2) and point position (x,y)
		Find where is point on rectangle and print message where is it ("Border","Inside" or "Outside")*/
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool xBorder = (x >= x1 && x <= x2) && (y == y1 || y==y2);
        bool yBorder = (y >= y1 && y <= y2) && (x == x1 || x==x2);

        if (xBorder||yBorder)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}