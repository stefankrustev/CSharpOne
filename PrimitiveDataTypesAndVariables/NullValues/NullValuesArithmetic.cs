/*Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/
using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullValuesOne = null;
        Console.WriteLine(nullValuesOne);
        double? nullValuesTwo = null;
        Console.WriteLine(nullValuesTwo);
        int? NullnewOne = nullValuesOne + 15;
        Console.WriteLine(NullnewOne);
        double? NullnewTwo = nullValuesTwo + 11;
        Console.WriteLine(NullnewTwo);
    }
}
