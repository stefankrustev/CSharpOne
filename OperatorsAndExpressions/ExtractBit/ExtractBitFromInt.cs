﻿/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/
using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int position = int.Parse(Console.ReadLine());

        int fakeBit = 1 << position;
        int foundBit = number & fakeBit;

        if (foundBit == 0)
        {
            Console.WriteLine("Bit of position {0} is '0'", position);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Bit of position {0} is '1'", position);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}

