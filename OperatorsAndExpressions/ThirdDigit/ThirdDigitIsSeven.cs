/*Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.*/
using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int otherNumber = number / 100;
        int thirdDigit = otherNumber % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digit of your number is seven!");
        }
        else
        {
            Console.WriteLine("The third digit of your number is not seven!");
        }
    }
}

