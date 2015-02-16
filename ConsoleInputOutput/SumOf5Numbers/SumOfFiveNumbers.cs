/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/
using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please input 5 numbers, separated by space: ");
        string[] userInput = Console.ReadLine().Split();
        double[] numbers = new double[5];
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = double.Parse(userInput[i]);
            sum += numbers[i];
        }
        Console.WriteLine("sum is: " + sum);
    }
}

