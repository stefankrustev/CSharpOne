/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/
using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double third = double.Parse(Console.ReadLine());

        int signCounter = 0;

        if ((first == 0) || (second == 0) || (third == 0))
        {
            Console.WriteLine("The product is 0");
        }

        else
        {
            if (first < 0)
            {
                signCounter++;
            }
            if (second < 0)
            {
                signCounter++;
            }
            if (third < 0)
            {
                signCounter++;
            }

            if (signCounter % 2 == 0)
            {
                Console.WriteLine("The sign of the product is + ");
            }
            else
            {
                Console.WriteLine("The sign of the product is - ");
            }
        }
    }
}

