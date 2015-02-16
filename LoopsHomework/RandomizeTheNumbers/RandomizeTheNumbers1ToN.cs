/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
*/
using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Random randomNumbers = new Random();

        for (int i = 1; i <= n; i++)
        {
            Console.Write(randomNumbers.Next(1, n + 1) + " ");
        }

        Console.WriteLine();
    }
}

