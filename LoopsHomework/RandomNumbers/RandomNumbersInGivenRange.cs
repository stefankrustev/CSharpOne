﻿/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/
using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(random.Next(min, max + 1) + " ");
            }

            Console.WriteLine();
        }
    }
}

