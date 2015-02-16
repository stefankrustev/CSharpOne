/*Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types 
and descriptive names.*/
using System;


class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Welcome to Online banking");
        Console.WriteLine("Please provide your data below in order to log in into your bank account");
        Console.WriteLine("Enter the name of your bank:");
        string inputBank = Console.ReadLine();
        Console.Write("Enter your First Name:");
        string inputName = Console.ReadLine();
        Console.Write("Enter your Middle Name:");
        string inputMName = Console.ReadLine();
        Console.Write("Enter your Last Name:");
        string inputLName = Console.ReadLine();
        Console.Write("Enter your password:");
        object inputPass = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Welcome to {0} Online Banking", inputBank);
        Console.WriteLine();
        Console.WriteLine("Your Name is: {0} {1} {2}", inputName, inputMName, inputLName);
        decimal balanceOfMoney = 3874.45M; 
        Console.WriteLine("Available bank balance: {0}lv", balanceOfMoney);
        string iBan = "BGN12FRW8345456677000";
        Console.WriteLine("IBAN / {0}", iBan);
        string bicCode = "BIC12345";
        Console.WriteLine("BIC CODE / {0}", bicCode);
        ulong creditCard1 = 6343574353247942;
        Console.WriteLine("The number of your VISA credit card is: {0}", creditCard1);
        ulong creditCard2 = 9867345114673224;
        Console.WriteLine("The number of your MASTERCARD credit card is: {0}", creditCard2);
        ulong creditCard3 = 7345894323474343;
        Console.WriteLine("The number of your American Express credit card is: {0}", creditCard3);

    }
}
