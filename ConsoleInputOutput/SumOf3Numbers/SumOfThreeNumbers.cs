/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/
using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of your number is: {0}", firstNumber + secondNumber + thirdNumber);
    }
}

