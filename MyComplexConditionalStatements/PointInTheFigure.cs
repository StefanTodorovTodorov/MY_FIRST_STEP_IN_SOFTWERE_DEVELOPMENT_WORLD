using System;

class PointInTheFigure
{
    static void Main()
    {
		/*Input figure size (h) and point position (x,y)
		Find where is point on figure and print message where is it ("Border","Inside" or "Outside")*/
		
        int h = int.Parse(Console.ReadLine());        
        int x = int.Parse(Console.ReadLine());        
        int y = int.Parse(Console.ReadLine());
        string position = null;

        int x1 = 0;
        int y1 = 0;
        int x2 = h * 3;
        int y2 = h;

        bool horizontalFigureInside = (x > x1 && x < x2) && (y > y1 && y < y2);
        bool horizontalFigureBorder = (x >= x1 && x <= x2 && (y == y1 || y == y2)) || (y >= y1 && y <= y2 && (x == x1 || x == x2));

        x1 = h;
        x2 = x1 + h;
        y1 = h;
        y2 = y1+(h * 3);
        bool verticalFigureInside = (x > x1 && x < x2) && (y > y1 && y < y2);
        bool verticalFigureBorder = (x >= x1 && x <= x2 && (y == y1 || y == y2)) || (y >= y1 && y <= y2 && (x == x1 || x == x2));

        bool noBorder = y == y1 && (x > x1 && x < x2);

        if (horizontalFigureInside || verticalFigureInside || noBorder)
        {
            position = "inside";
        }
        else if ((verticalFigureBorder || horizontalFigureBorder) && !noBorder)
        {
            position = "border";
        }
        else
        {
            position = "outside";
        }
        Console.WriteLine(position);
    }
}