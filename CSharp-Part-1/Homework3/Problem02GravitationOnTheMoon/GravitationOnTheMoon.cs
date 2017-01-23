//Problem 2. Gravitation on the Moon
// The gravitational field of the Moon is approximately  17%  of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

namespace Problem02GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Single weight;

            Console.WriteLine("Enter your weight:");

            try
            {
                weight = Single.Parse(Console.ReadLine());

                Console.WriteLine("Your weight on the moon will be {0:#.###}", (weight * 0.17f));
            }
            catch (FormatException)
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
