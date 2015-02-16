/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) 
 that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/
using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Value of bit [0 or 1]: ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        if (value == 1)
        {
            int setOne = 1 << position;
            int foundBitOne = number | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitOne);
        }
        else
        {
            int setZero = ~(1 << position);
            int foundBitZero = number & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitZero);
        }
    }
}

