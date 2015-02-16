/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
using System;

class PlayWIntDoubleNString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.Write("1-->int\n2-->double\n3-->string\n");
        int input = int.Parse(Console.ReadLine());
        if (input >= 1 && input <= 3)
        {
            switch (input)
            {
                case 1:
                    Console.Write("Enter whole number: ");
                    int wholeNumber = int.Parse(Console.ReadLine());
                    int sum = wholeNumber + 1;
                    Console.WriteLine(sum); break;
                case 2: Console.Write("Enter decimal number: ");
                    double decimalNumber = double.Parse(Console.ReadLine());
                    double sum2 = decimalNumber + 1;
                    Console.WriteLine(sum2); break;
                case 3: Console.Write("Type some word: ");
                    string word = Console.ReadLine();
                    Console.WriteLine(word + "*"); break;
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

