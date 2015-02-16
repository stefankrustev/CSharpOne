/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/
using System;

class TheBiggestFromThreeNumbers
{
    static void Main()
    {
        Console.Write("Type first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Type second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Type third number: ");
        double third = double.Parse(Console.ReadLine());

        if (first > second && first > third)
        {
            Console.WriteLine("Biggest number is: {0}", first);
        }
        else if (second > first && second > third)
        {
            Console.WriteLine("Biggest number is: {0}", second);
        }
        else
        {
            Console.WriteLine("Biggest number is: {0}", third);
        }

    }
}

