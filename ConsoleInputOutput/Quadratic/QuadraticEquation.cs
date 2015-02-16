/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
(prints its real roots).*/
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Type number for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Type number for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Type number for c: ");
        double c = double.Parse(Console.ReadLine());
        double equation = (b * b) - 4 * a * c;
        double equationSqrt = Math.Sqrt(equation);
        double x1 = (-b - equationSqrt) / (2 * a);
        double x2 = (-b + equationSqrt) / (2 * a);
        if (x1 == x2)
        {
            Console.WriteLine("x1=x2={0}", x1);
        }
        else
        {
            Console.WriteLine("x1={0}", x1);
            Console.WriteLine("x2={0}", x2);
        }
    }
}

