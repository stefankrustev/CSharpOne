﻿/*Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/
using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger factN = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }

        Console.WriteLine("trailing zeroes of n! = " + (n / 5));
        Console.WriteLine(factN);
    }
}

