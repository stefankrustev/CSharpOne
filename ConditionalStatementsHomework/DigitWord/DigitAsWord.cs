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
            case 0: digit = 0; Console.WriteLine("You enter \"zero\""); break;
            case 1: digit = 1; Console.WriteLine("You enter \"one\""); break;
            case 2: digit = 2; Console.WriteLine("You enter \"two\""); break;
            case 3: digit = 3; Console.WriteLine("You enter \"three\""); break;
            case 4: digit = 4; Console.WriteLine("You enter \"four\""); break;
            case 5: digit = 5; Console.WriteLine("You enter \"five\""); break;
            case 6: digit = 6; Console.WriteLine("You enter \"six\""); break;
            case 7: digit = 7; Console.WriteLine("You enter \"seven\""); break;
            case 8: digit = 8; Console.WriteLine("You enter \"eight\""); break;
            case 9: digit = 9; Console.WriteLine("You enter \"nine\""); break;
            default:
                Console.WriteLine("\"{0}\" is not a valid digit!", digit);
                break;

        }
    }
}

