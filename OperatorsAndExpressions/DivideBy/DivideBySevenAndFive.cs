/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/
using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Type a number to check if it can be divided by 5 and 7 at the same time: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("{0} can be divided by both 5 and 7!", number);
        }
        else
        {
            Console.WriteLine("{0} can NOT be divided by 5 and 7!", number);
        }
    }
}

