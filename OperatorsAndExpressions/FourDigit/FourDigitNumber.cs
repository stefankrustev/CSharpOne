/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/
using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter number between 1000 and 9999: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 999 && number <= 9999 )
        {
           
                int firstDigit = number % 10;

                int secondNumber = number / 10;
                int secondDigit = secondNumber % 10;

                int thirdNumber = number / 100;
                int thirdDigit = thirdNumber % 10;

                int fourthNumber = number / 1000;
                int fourthDigit = fourthNumber % 10;

                Console.WriteLine("Your number is: {0}", number);
                Console.WriteLine("Sum of digits: {0} ", (firstDigit + secondDigit + thirdDigit + fourthDigit));
                Console.WriteLine("Reversed: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
                Console.WriteLine("Last digits in front: {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
                Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
           
        }
        else
        {
            Console.WriteLine("Incorrect number!");
        }

    }
}

