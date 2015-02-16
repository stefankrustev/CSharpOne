﻿/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter integer a: ");
        int intA = int.Parse(Console.ReadLine());
        while (intA < 0 || intA > 500) //Check number is valid
        {
            Console.WriteLine("Invalid input, your number must be between 0 and 500! Try again!");
            Console.Write("Enter integer a: ");
            intA = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter floating point number b: ");
        decimal decimalB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter floating point number c: ");
        decimal decimalC = decimal.Parse(Console.ReadLine());
        Console.Write("{0,-8:x} |", intA);
        Console.Write(Convert.ToString(intA, 2).PadLeft(10, '0'));
        Console.Write("| {0,8:F2}", decimalB);
        Console.Write("| {0,-6:F3} |", decimalC);
        Console.WriteLine();
    }
}

