/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager.
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/
using System;
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string compName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        int compPhoneNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter company fax number: ");
        int compFaxNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter company website: ");
        string compWebsite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string managerFName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        int manAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number: ");
        int manPhone = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("{0}", compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Tel.: +359{0}", compPhoneNumber);
        Console.WriteLine("Fax: {0}", compFaxNumber);
        Console.WriteLine("Web site: {0}", compWebsite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel.: +359{3})", managerFName, managerLName, manAge, manPhone);
    }
}

