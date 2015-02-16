/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.*/
using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter card: ");
        string card = Console.ReadLine();

        string[] playCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        
        if (Array.IndexOf(playCards,card) >=0)
        {
            Console.WriteLine("Yes \"{0}\" is valid play card!", card);
        }
        else
        {
            Console.WriteLine("\"{0}\" is not valid play card!", card);
        }
    }
}

