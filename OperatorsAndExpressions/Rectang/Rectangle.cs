/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/
using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * width) + (2 * height);
        double area = width * height;

        Console.WriteLine("Perimeter of rectangle is: {0}", perimeter);
        Console.WriteLine("Area of rectangle is: {0}", area);
    }
}

