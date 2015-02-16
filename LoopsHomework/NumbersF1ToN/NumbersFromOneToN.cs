/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
on a single line, separated by a space.*/
using System;

class NumbersFromOneToN
{
    static void Main()
    {

        Console.Write("Enter some positive number: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;

        if (number > 0)
        {

            while (counter <= number)
            {
                Console.Write("{0} ", counter);
                counter++;
            }

            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Your number is not positive!");
        }
    }
}

