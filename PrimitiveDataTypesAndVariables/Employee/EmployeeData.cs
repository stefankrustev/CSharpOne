﻿/*Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.*/
using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First Name:");
        string inputName = Console.ReadLine();
        Console.Write("Last Name:");
        string inputLName = Console.ReadLine();
        Console.Write("Age:");
        string inputAge = Console.ReadLine();
        byte age = byte.Parse(inputAge);
        Console.Write("Gender(m or f):");
        string gender = Console.ReadLine();

        Console.Write("ID number(1 to 20000000):");
        string inputIDNum = Console.ReadLine();
        int idNumber = int.Parse(inputIDNum);
        if (idNumber < 1)
        {
            Console.WriteLine("Wrong ID number");
        }
        else if (idNumber > 20000000)
        {
            Console.WriteLine("Wrong ID number");
        }

        Console.WriteLine("Your name is: {0} {1}", inputName, inputLName);
        Console.WriteLine("Your age is: {0}", inputAge);
        Console.WriteLine("Your gender is: {0}", gender);
        Console.WriteLine("Your ID number is: {0}", inputIDNum);
    }
}