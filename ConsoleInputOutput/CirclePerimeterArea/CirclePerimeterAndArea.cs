/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Type number r= ");
        double r = double.Parse(Console.ReadLine());
        double p = 2 * (Math.PI) * r;
        double s = Math.PI * (r * r);
        Console.WriteLine("Perimeter is: {0}", Math.Round(p, 2));
        Console.WriteLine("Area is: {0}", Math.Round(s, 2));
    }
}

