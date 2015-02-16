/*Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.*/
using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a digit from 0 to 9: ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0: digit = 0; Console.WriteLine("You enter \"Zero\""); break;
            case 1: digit = 1; Console.WriteLine("You enter \"One\""); break;
            case 2: digit = 2; Console.WriteLine("You enter \"Two\""); break;
            case 3: digit = 3; Console.WriteLine("You enter \"Three\""); break;
            case 4: digit = 4; Console.WriteLine("You enter \"Four\""); break;
            case 5: digit = 5; Console.WriteLine("You enter \"Five\""); break;
            case 6: digit = 6; Console.WriteLine("You enter \"Six\""); break;
            case 7: digit = 7; Console.WriteLine("You enter \"Seven\""); break;
            case 8: digit = 8; Console.WriteLine("You enter \"Eight\""); break;
            case 9: digit = 9; Console.WriteLine("You enter \"Nine\""); break;
            default:
                Console.WriteLine("\"{0}\" is not a valid digit!", digit);
                break;

        }
    }
}

