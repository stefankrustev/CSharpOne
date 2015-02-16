/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/
using System;
class PointInACircle
{
    static void Main()
    {
        Console.Write("Type in number for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Type in number for y: ");
        double y = double.Parse(Console.ReadLine());

        double inside = (x * x) + (y * y);
        if (inside <= (2 * 2))
        {
            Console.WriteLine("Points are inside a circle!");
        }
        else
        {
            Console.WriteLine("Point are not inside a circle!");
        }
    }
}

