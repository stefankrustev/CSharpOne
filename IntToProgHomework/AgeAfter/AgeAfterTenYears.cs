/*  Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/
using System;

class AgeAfterTenYears
{
    static void Main()
    {
      
        DateTime birthDay = new DateTime(1987, 12, 17);
        DateTime todaysDate = DateTime.Now;

        var MyAge = todaysDate.Year - birthDay.Year;
 
        Console.WriteLine("My Age is: " + MyAge);

        var myFutureAge = MyAge + 10;

        Console.WriteLine("My Age in 10 years will be: " + myFutureAge);
      
    }
}

