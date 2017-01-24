//Problem 2. Bonus Score
//• Write a program that applies bonus score to given score in the range  [1…9]  by the following rules: ◦ If the score is between  1  and  3 , the program multiplies it by  10 .
//◦ If the score is between  4  and  6 , the program multiplies it by  100 .
//◦ If the score is between  7  and  9 , the program multiplies it by  1000 .
//◦ If the score is  0  or more than  9 , the program prints  “invalid score” .

using System;

namespace Problem02BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter number in range [1..9]: ");
            int i = int.Parse(Console.ReadLine());

            if ((i >= 1) && (i <= 3))
            {
                Console.WriteLine("Score: " + (i * 10));
            }
            else if ((i >= 4) && (i <= 6))
            {
                Console.WriteLine("Score: " + (i * 100));
            }
            else if ((i >= 7) && (i <= 9))
            {
                Console.WriteLine("Score: " + (i * 1000));
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
