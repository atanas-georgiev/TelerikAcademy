//using System;
//namespace Exam_29_Dec_2012
//{
//    public static class IntExtensions
//    {
//        public static int SetBit(this int target, int field, bool value)
//        {
//            if (value == true)
//            {
//                return (target | (1 << field));
//            }
//            else
//            {
//                return (target & ~(1 << field));
//            }
//        }

//        public static bool GetBit(this int target, int field)
//        {
//            return (target & (1 << field)) != 0;
//        }
//    }

//    class Program
//    {
//        const int cSize = 8;
//        static int[] data = new int[cSize];

//        static int DestoryPig(int x, int y)
//        {
//            if (data[x].GetBit(y) == false)
//            {
//                // no hit, 0 score
//                return 0;
//            }
//            else
//            {
//                // hit, erase pigs and calculate score
//                int x1, x2, y1, y2;
//                int score = 0;

//                x1 = x - 1;
//                x2 = x + 1;
//                if (x1 < 0) x1 = 0;
//                if (x2 > 7) x2 = 7;

//                y1 = y - 1;
//                y2 = y + 1;
//                if (y1 < 0) y1 = 0;
//                if (y2 > 7) y2 = 7;

//                for (int i = x1; i <= x2; i++)
//                    for (int j = y1; j <= y2; j++)
//                        if (data[i].GetBit(j) == true)
//                        {
//                            score++;
//                            data[i] = data[i].SetBit(j, false);
//                        }
//                return score;
//            }
//        }

//        static int PlayGame(int x, int y)
//        {
//            int score = 0;
//            int res;
//            bool isDirectionUp = true;
//            x--;
//            y--;

//            if (x < 0)
//            {
//                x = 1;
//                isDirectionUp = false;
//            }

//            while (true)
//            {
//                if (x < 0)
//                {
//                    x = 1;
//                    isDirectionUp = false;
//                }

//                score++;
//                res = DestoryPig(x, y);

//                if (res != 0)
//                {
//                    score *= res;
//                    return score;
//                }

//                y--;

//                if (isDirectionUp == true)
//                {
//                    x--;
//                }
//                else
//                {
//                    x++;
//                }

//                if (y < 0)
//                {
//                    return score;
//                }

//                if (x > 7)
//                {
//                    return score;
//                }
//            }
//        }

//        static void Main()
//        {
//            int i, j;
//            int score = 0;

//            for (i = 0; i < cSize; i++)
//            {
//                data[i] = ushort.Parse(Console.ReadLine());
//            }

//            for (j = 8; j < 16; j++)
//            {
//                for (i = 0; i < cSize; i++)
//                {
//                    if (data[i].GetBit(j) == true)
//                    {
//                        // Bird found, erase it and play with it
//                        data[i] = data[i].SetBit(j, false);
//                        score += PlayGame(i, j);
//                    }
//                }
//            }

//            bool PigsAvailable = false;

//            for (j = 0; j < cSize; j++)
//            {
//                for (i = 0; i < cSize; i++)
//                {
//                    if (data[i].GetBit(j) == true)
//                    {
//                        PigsAvailable = true;
//                        break;
//                    }
//                }
//            }

//            Console.WriteLine("{0} {1}", score, PigsAvailable == false ? "Yes" : "No");
//        }
//    }
//}

using System;

class AngryBits
{
    static void Main()
    {
        int[,] field = new int[8, 16];
        int result = 0;
        for (int i = 0; i < 8; i++)
        {
            ushort number = ushort.Parse(Console.ReadLine());
            for (int j = 0; j < 16; j++)
            {
                field[i, j] = TakeBit(j, number);
            }
        }
        for (int j = 8; j < 16; j++)
        {
            int birdRow = -1;
            int birdCol = -1;
            int addToRow = -1;
            int flight = 0;
            int hit = 0;
            for (int i = 0; i < 8; i++)
            {
                if (field[i, j] == 1)
                {
                    birdRow = i;
                    birdCol = j;
                    field[i, j] = 0;
                    break;
                }
            }
            if (birdRow >= 0)
            {
                do
                {
                    flight++;
                    birdCol--;
                    if ((birdRow + addToRow < 0) || (birdRow + addToRow > 7))
                    {
                        addToRow *= -1;
                    }
                    birdRow += addToRow;
                    if ((birdCol < 8) && (field[birdRow, birdCol] == 1))
                    {
                        for (int k = birdRow - 1; k <= birdRow + 1; k++)
                        {
                            for (int l = birdCol - 1; l <= birdCol + 1; l++)
                            {
                                if ((k >= 0) && (k < 8) && (l >= 0) && (l < 8))
                                {
                                    if (field[k, l] == 1)
                                    {
                                        hit++;
                                        field[k, l] = 0;
                                    }
                                }
                            }
                        }
                        birdCol = -1;
                    }
                    if (birdRow == 7)
                    {
                        birdCol = -1;
                    }
                } while (birdCol > 0);
            }

            result += hit * flight;
        }
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                sum += field[i, j];
            }
        }
        string win = "No";
        if (sum == 0)
        {
            win = "Yes";
        }
        Console.WriteLine("{0} {1}", result, win);
    }
    static int TakeBit(int position, int number)
    {
        int bit = ((1 << position) & number) >> position;
        return bit;
    }
}