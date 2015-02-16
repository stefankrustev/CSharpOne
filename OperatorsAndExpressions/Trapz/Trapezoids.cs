/* Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h. */
using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Type number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Type number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Type number for h: ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;

            Console.WriteLine("Area of trapezoid is " + area);
        }
    }

