using System;

class PointInRectangle
{
    static void Main()
    {
		/*Input rectangle border (x1,y1,x2,y2) and point position (x,y)
		Find where is point on rectangle and print message where is it ("Inside" or "Outside")*/
		
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        string position = null;
        bool x1y1Border = x1 <= x && y1 <= y;
        bool x2y2Border = x2 >= x && y2 >= y;

        if (x1y1Border && x2y2Border)
        {
            position = "Inside";
        }
        else
        {
            position = "Outside";
        }
        Console.WriteLine(position);
    }
}