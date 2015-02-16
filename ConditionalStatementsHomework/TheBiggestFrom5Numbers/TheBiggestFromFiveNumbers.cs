/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.*/
using System;

class TheBiggestFromFiveNumbers
{
    static void Main()
    {
        Console.Write("Type first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Type second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Type third number: ");
        double third = double.Parse(Console.ReadLine());
        Console.Write("Type fourth number: ");
        double fourth = double.Parse(Console.ReadLine());
        Console.Write("Type fifth number: ");
        double fifth = double.Parse(Console.ReadLine());

        if (first > second && first > third && first > fourth && first > fifth)
        {
            Console.WriteLine("Biggest number is: {0}", first);
        }
        else if (second > third && second > fourth && second > fifth)
        {
            Console.WriteLine("Biggest number is: {0}", second);
        }
        else if (third > fourth && third > fifth)
        {
            Console.WriteLine("Biggest number is: {0}", third);
        }
        else if (fourth > fifth)
        {
            Console.WriteLine("Biggest number is: {0}", fourth);
        }
        else
        {
            Console.WriteLine("Biggest number is: {0}", fifth);
        }
    }
}

