/*Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
using System;

class PointIndiseInCircleNOutsideRectangle
{
    static void Main()
    {
        Console.Write("Type number for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Type number for y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

        if (x == 0 || y == 0)
        {
            Console.WriteLine("No, its not inside K and outside of R");
        }
        else if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("Yes its inside K and outside of R");
        }
        else
        {
            Console.WriteLine("No, its not inside K and outside of R");
        }
    }
}

