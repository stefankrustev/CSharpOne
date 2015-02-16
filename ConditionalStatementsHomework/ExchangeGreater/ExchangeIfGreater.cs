/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
As a result print the values a and b, separated by a space.*/
using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Type number for double a: ");
        double doubleA = double.Parse(Console.ReadLine());
        Console.Write("Type number for double b: ");
        double doubleB = double.Parse(Console.ReadLine());

        if (doubleA > doubleB)
        {
            Console.WriteLine("Greater double is {0} and the smaller is {1}", doubleA, doubleB);
        }
        else
        {
            Console.WriteLine("Greater double is {0} and the smaller is {1}", doubleB, doubleA);
        }
    }
}

