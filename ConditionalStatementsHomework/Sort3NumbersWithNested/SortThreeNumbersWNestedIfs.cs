/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.*/
using System;

class SortThreeNumbersWNestedIfs
{
    static void Main()
    {
        Console.Write("Type first number: ");
        double firstDouble = double.Parse(Console.ReadLine());
        Console.Write("Type second number: ");
        double secondDouble = double.Parse(Console.ReadLine());
        Console.Write("Type third number: ");
        double thirdDouble = double.Parse(Console.ReadLine());

        double first = 0;
        double second = 0;
        double third = 0;

        if (firstDouble >= secondDouble)
        {
            if (firstDouble >= thirdDouble)
            {
                first = firstDouble;

                if (secondDouble >= thirdDouble)
                {
                    second = secondDouble;
                    third = thirdDouble;
                }
                else
                {
                    second = thirdDouble;
                    third = secondDouble;
                }
            }
            else
            {
                first = thirdDouble;
                second = firstDouble;
                third = secondDouble;
            }
        }

        else
        {
            if (secondDouble >= thirdDouble)
            {
                first = secondDouble;

                if (firstDouble >= thirdDouble)
                {
                    second = firstDouble;
                    third = thirdDouble;
                }
                else
                {
                    second = thirdDouble;
                    third = firstDouble;
                }
            }
            else
            {
                first = thirdDouble;
                second = secondDouble;
                third = firstDouble;
            }
        }

        Console.WriteLine(first + " " + second + " " + third);
        
        
    }

    public static object FirstDouble { get; set; }
}

