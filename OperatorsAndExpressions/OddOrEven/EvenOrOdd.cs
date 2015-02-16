/* Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/
using System;

class EvenOrOdd
{
    static void Main()
    {
        Console.Write("Type a number to check if it's odd or even: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is even!", number);
        }
        else
        {
            Console.WriteLine("{0} is odd!", number);
        }
    }
}