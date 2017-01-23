using System;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            string[] cards = new string[5];
            int[] colors = new int[13];

            for (int i = 0; i < 5; i++)
            {
                cards[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                switch (cards[i])
                {
                    case "A":
                        colors[0]++;
                        break;
                    case "2":
                        colors[1]++;
                        break;
                    case "3":
                        colors[2]++;
                        break;
                    case "4":
                        colors[3]++;
                        break;
                    case "5":
                        colors[4]++;
                        break;
                    case "6":
                        colors[5]++;
                        break;
                    case "7":
                        colors[6]++;
                        break;
                    case "8":
                        colors[7]++;
                        break;
                    case "9":
                        colors[8]++;
                        break;
                    case "10":
                        colors[9]++;
                        break;
                    case "J":
                        colors[10]++;
                        break;
                    case "Q":
                        colors[11]++;
                        break;
                    case "K":
                        colors[12]++;
                        break;
                    default:
                        break;
                }
            }

            int fives = 0;
            int fourth = 0;
            int thirds = 0;
            int seconds = 0;
            bool strait = false;

            // five cards are equal
            foreach (int a in colors)
            {
                if (a == 5) fives++;
                if (a == 4) fourth++;
                if (a == 3) thirds++;
                if (a == 2) seconds++;
            }

            for (int k = 0; k < 9; k++)
            {
                if (colors[k] == 1 && colors[k+1] == 1 && colors[k+2] == 1 && colors[k+3] == 1 && colors[k+4] == 1)
                {
                    strait = true;
                }

                if (colors[9] == 1 && colors[10] == 1 && colors[11] == 1 && colors[12] == 1 && colors[0] == 1)
                {
                    strait = true;
                }
            }

            if (fives == 1)
            {
                Console.WriteLine("Impossible");
            }
            else if (fourth == 1)
            {
                Console.WriteLine("Four of a Kind");
            }
            else if (thirds == 1 && seconds == 1)
            {
                Console.WriteLine("Full House");
            }
            else if (thirds == 1)
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (seconds == 2)
            {
                Console.WriteLine("Two Pairs");
            }
            else if (seconds == 1)
            {
                Console.WriteLine("One Pair");
            }
            else if (strait == true)
            {
                Console.WriteLine("Straight");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
