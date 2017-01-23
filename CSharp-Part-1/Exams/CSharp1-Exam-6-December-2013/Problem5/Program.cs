using System;

namespace Problem5
{
    public static class IntExtensions
    {
         public static int SetBit(this int target, int field, bool value)
        {
            field = 15 - field;

            if (value == true)
            {
                return target | (1 << field);
            }
            else
            {
                return target & ~(1 << field);
            }
        }

        public static bool GetBit(this int target, int field)
        {
            field = 15 - field;
            return (target & (1 << field)) != 0;
        }
    }
    class Program
    {
        const int size = 16;
     //   static char[][] input = new char[16][];
        static int[] data = new int[size];

        

        static void RemoveDetonator(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                    data[i] = data[i].SetBit(j, false);
        }

        static bool IsDetonator(int x, int y)
        {
            int x1, x2, y1, y2;
            int sum = 0;

            x1 = x - 1;
            x2 = x + 1;
            if (x1 < 0) x1 = 0;
            if (x2 > 15) x2 = 15;

            y1 = y - 1;
            y2 = y + 1;
            if (y1 < 0) y1 = 0;
            if (y2 > 15) y2 = 15;

            for (int i = x1; i <= x2; i++)
                for (int j = y1; j <= y2; j++)
                    if (data[i].GetBit(j) == true)
                        sum++;

            if ((sum == 8) && (data[x].GetBit(y) == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {

        /*    data[0] = Convert.ToInt32("0110000000000000", 2);
            data[1] = Convert.ToInt32("1010000000000000", 2);
            data[2] = Convert.ToInt32("1110000001110000", 2);
            data[3] = Convert.ToInt32("0000000001010000", 2);
            data[4] = Convert.ToInt32("0000000001010000", 2);
            data[5] = Convert.ToInt32("0000000000000000", 2);
            data[6] = Convert.ToInt32("0000100001110000", 2);
            data[7] = Convert.ToInt32("0000100001010000", 2);
            data[8] = Convert.ToInt32("0000100001110000", 2);
            data[9] = Convert.ToInt32("0000000000000000", 2);
            data[10] = Convert.ToInt32("0000000100000000", 2);
            data[11] = Convert.ToInt32("0000000000000000", 2);
            data[12] = Convert.ToInt32("0000000000000000", 2);
            data[13] = Convert.ToInt32("0000000000000000", 2);
            data[14] = Convert.ToInt32("0000000000000000", 2);
            data[15] = Convert.ToInt32("0000000000000000", 2);
            */
            int x, y;
            int i, j;
            bool exit = false;

            for (i = 0; i < 16; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine(),2);
            }

            do
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "hover":
                        x = int.Parse(Console.ReadLine());
                        y = int.Parse(Console.ReadLine());

                        if (data[x].GetBit(y) == true)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }

                        break;
                    case "operate":
                        x = int.Parse(Console.ReadLine());
                        y = int.Parse(Console.ReadLine());

                        if (data[x].GetBit(y) == true)
                        {
                            int sum = 0;
                            Console.WriteLine("missed");
                            for (i = 0; i < 16; i++)
                                for (j = 0; j < 16; j++)
                                    if (IsDetonator(i, j) == true)
                                        sum++;
                            Console.WriteLine(sum);
                            Console.WriteLine("BOOM");
                            exit = true;
                        }
                        else
                        {
                            if (IsDetonator(x, y) == true)
                            {
                                RemoveDetonator(x, y);
                            }
                        }
                        break;
                    case "cut":
                        string command2 = Console.ReadLine();

                        if (command2 == "red")
                        {
                            int sum = 0;
                            for (i = 0; i < 16; i++)
                                for (j = 0; j < 8; j++)
                                    if (IsDetonator(i, j) == true)
                                        sum++;
                            if (sum != 0)
                            {
                                Console.WriteLine(sum);
                                Console.WriteLine("BOOM");
                                exit = true;
                            }
                            else
                            {
                                sum = 0;
                                for (i = 0; i < 16; i++)
                                    for (j = 8; j < 15; j++)
                                        if (IsDetonator(i, j) == true)
                                            sum++;
                                Console.WriteLine(sum);
                                Console.WriteLine("disarmed");
                                exit = true;
                            }
                        }
                        else if (command2 == "blue")
                        {
                            int sum = 0;
                            for (i = 0; i < 16; i++)
                                for (j = 8; j < 16; j++)
                                    if (IsDetonator(i, j) == true)
                                        sum++;
                            if (sum != 0)
                            {
                                Console.WriteLine(sum);
                                Console.WriteLine("BOOM");
                                exit = true;
                            }
                            else
                            {
                                sum = 0;
                                for (i = 0; i < 16; i++)
                                    for (j = 0; j < 8; j++)
                                        if (IsDetonator(i, j) == true)
                                            sum++;
                                Console.WriteLine(sum);
                                Console.WriteLine("disarmed");
                                exit = true;
                            }
                        }

                        break;
                    default:
                        break;
                }
            }
            while (exit == false);
        }
    }
}
