using System;

class TrainingLab
{
    static void Main()
    {
        double heightRoom = double.Parse(Console.ReadLine());
        double weightRoom = double.Parse(Console.ReadLine());
        weightRoom = (weightRoom * 100) - 100;
        heightRoom *= 100;
        double tablesInOneRow =Math.Truncate( weightRoom / 70);
        double tablesRows = Math.Truncate( heightRoom / 120);
        double totalWorkPlaces = (tablesInOneRow * tablesRows)-3;
        Console.WriteLine(totalWorkPlaces);
    }
}