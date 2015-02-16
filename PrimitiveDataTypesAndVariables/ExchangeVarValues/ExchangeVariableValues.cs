/*Problem 9. Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values 
by using some programming logic.
Print the variable values before and after the exchange.*/
using System;

class VariableValues
{
    static void Main()
    {
        int aInteger = 5;
        int bInteger = 10;
        Console.WriteLine("\"A\" is {0} \n\"B\"is {1}",aInteger, bInteger);
        aInteger = aInteger + bInteger;
        bInteger = aInteger - bInteger;
        aInteger = aInteger - bInteger;
        Console.WriteLine("Now\n\"A is {0} \n\"B\" is {1}", aInteger, bInteger);
        
    }
}