﻿﻿/*Problem 11.* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.*/
using System;

class NumberWord
{
    static void Main()
    {
        Console.WriteLine("Enter a number, that will be coverted to text [0-999]");
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number % 100) / 10;
        int ones = number % 10;

        if (hundreds > 0 && hundreds < 10)
        {
            switch (hundreds)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            if ((tens == 0 && ones > 0) || tens == 1)
            {
                Console.Write("and ");
            }
        }
        if (tens == 1)
        {
            switch (ones)
            {
                case 0:
                    Console.WriteLine("Ten");
                    break;
                case 1:
                    Console.WriteLine("Eleven");
                    break;
                case 2:
                    Console.WriteLine("Twelve");
                    break;
                case 3:
                    Console.WriteLine("Thirteen");
                    break;
                case 4:
                    Console.WriteLine("Fourteen");
                    break;
                case 5:
                    Console.WriteLine("Fifteen");
                    break;
                case 6:
                    Console.WriteLine("Sixteen");
                    break;
                case 7:
                    Console.WriteLine("Seventeen");
                    break;
                case 8:
                    Console.WriteLine("Eighteen");
                    break;
                case 9:
                    Console.WriteLine("Nineteen");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        if (tens > 1)
        {
            switch (tens)
            {
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Fourty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        if (tens != 1)
        {
            switch (ones)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        if (hundreds == 0 && tens == 0 && ones == 0)
        {
            Console.WriteLine("Zero");
        }
    }
}