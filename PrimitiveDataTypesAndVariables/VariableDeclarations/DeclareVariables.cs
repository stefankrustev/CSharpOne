/*Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */
using System;


class DeclareVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        long thirdNumber = 4825932;
        byte fourthNumber = 97;
        short fifthNumber = -10000;
        Console.WriteLine("The values are:\n{0}\n{1}\n{2}\n{3}\n{4}", firstNumber, secondNumber,thirdNumber, fourthNumber, fifthNumber );
    }
}

