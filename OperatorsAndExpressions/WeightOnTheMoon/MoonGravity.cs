/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/
using System;

class MoonGravity
{
    static void Main()
    {
        Console.Write("Enter your Earth weight in kg's to calculate what will be on the Moon: ");
        double weight = double.Parse(Console.ReadLine());

        double weightMoon = weight * 0.17;
        Console.WriteLine("If you happen to be on the Moon, your weight there will be: {0} kg's", weightMoon);

    }
}

