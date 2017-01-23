using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    enum DirectionEnum
    {
        Left,
        Right,
        Up,
        Down
    }

    enum MoveEnum
    {
        Left,
        Right,
        Ahead
    }
    struct Point
    {
        public int X;
        public int Y;
    }

    class Player
    {
        public Player(int x, int y, DirectionEnum direction)
        {
            Position.X = x;
            Position.Y = y;
            startPosition.X = x;
            startPosition.Y = y;
            IsDead = false;
            Direction = direction;
        }

        public Point Position;
        public Point startPosition;
        public bool IsDead;
        public DirectionEnum Direction;

        public Point Move(MoveEnum move)
        {
            switch (Direction)
            {
                case DirectionEnum.Right:
                    switch (move)
                    {
                        case MoveEnum.Left:
                            Direction = DirectionEnum.Up;
                            break;
                        case MoveEnum.Right:
                            Direction = DirectionEnum.Down;
                            break;
                        default:
                            this.Position.Y++;
                            return Position;
                    }
                    break;
                case DirectionEnum.Left:
                    switch (move)
                    {
                        case MoveEnum.Left:
                            Direction = DirectionEnum.Down;
                            break;
                        case MoveEnum.Right:
                            Direction = DirectionEnum.Up;
                            break;
                        default:
                            this.Position.Y--;
                            return Position;
                    }
                    break;
                case DirectionEnum.Up:
                    switch (move)
                    {
                        case MoveEnum.Left:
                            Direction = DirectionEnum.Left;
                            break;
                        case MoveEnum.Right:
                            Direction = DirectionEnum.Right;
                            break;
                        default:
                            this.Position.X--;
                            return Position;
                    }
                    break;
                case DirectionEnum.Down:
                    switch (move)
                    {
                        case MoveEnum.Left:
                            Direction = DirectionEnum.Right;
                            break;
                        case MoveEnum.Right:
                            Direction = DirectionEnum.Left;
                            break;
                        default:
                            this.Position.X++;
                            return Position;
                    }
                    break;

                default:
                    break;
            }
            return Position;
        }
    }

    class PlayBoard
    {
        public PlayBoard(int x, int y)
        {
            matrixBoard = new int[x, y];
            maxX = x;
            maxY = y;
        }

        public int maxX, maxY;
        private int[,] matrixBoard;

        public int this[int x, int y]
        {
            get
            {
                return matrixBoard[x, y];
            }

            set
            {
                matrixBoard[x, y] = value;
            }
        }
        public bool ReservePoint(Point p)
        {
            bool res = true;

            if (p.Y >= maxY)
            {
                return false;
            }

            if (p.Y < 0)
            {
                return false;
            }

            if (matrixBoard[p.X, p.Y] == 0)
            {
                matrixBoard[p.X, p.Y] = 1;
            }
            else
            {
                return false;
            }

            return res;
        }

        public override string ToString()
        {
            string res = "";
            for (int k = 0; k < maxX; k++)
            {
                for (int l = 0; l < maxY; l++)
                {
                    res += (matrixBoard[k, l]);
                }
                res += Environment.NewLine;
            }
            return res;
        }

    }

    class Program
    {
        static string Decode(string message)
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                int n = 0;
                int startPos = i;
                while (Char.IsDigit(message[i]))
                {
                    n++;
                    i++;
                }

                if ((!Char.IsDigit(message[i])) && (n == 0))
                {
                    res.Append(message[i]);
                }
                else if (n != 0)
                {
                    for (int j = 0; j < int.Parse(message.Substring(startPos, n)); j++)
                    {
                        res.Append(message[i]);
                    }
                }
            }

            return res.ToString();
        }

        static void Main(string[] args)
        {
            int x, y, z;
            string[] coordinates = Console.ReadLine().Split(' ');
            x = int.Parse(coordinates[0]);
            y = int.Parse(coordinates[1]);
            z = int.Parse(coordinates[2]);

            PlayBoard board = new PlayBoard(2 * (x + z) + 1, y + 1);
            Player redPlayer = new Player(z + x / 2, y / 2, DirectionEnum.Down);
            Player bluePlayer = new Player(z + x / 2 + z + x, y / 2, DirectionEnum.Up);

            board.ReservePoint(redPlayer.Position);
            board.ReservePoint(bluePlayer.Position);

            string MovesRed = Decode(Console.ReadLine());
            string MovesBlue = Decode(Console.ReadLine());

            int cntRed = 0;
            int cntBlue = 0;

            Point temp;

            while (true)
            {
                if (cntRed >= MovesRed[cntRed])
                {

                }
                else if (MovesRed[cntRed] == 'M')
                {
                    temp = redPlayer.Move(MoveEnum.Ahead);
                    if (temp.Y >= board.maxY)
                    {
                        temp.Y = 0;
                    }
                    if (board.ReservePoint(temp) == false)
                    {
                        redPlayer.IsDead = true;
                    }
                    cntRed++;
                }
                else if (MovesRed[cntRed] == 'L')
                {
                    redPlayer.Move(MoveEnum.Left);
                    temp = redPlayer.Move(MoveEnum.Ahead);
                    if (temp.Y >= board.maxY)
                    {
                        temp.Y = 0;
                    }
                    if (board.ReservePoint(temp) == false)
                    {
                        redPlayer.IsDead = true;
                    }
                    cntRed++;
                    cntRed++;
                }
                else if (MovesRed[cntRed] == 'R')
                {
                    redPlayer.Move(MoveEnum.Right);
                    temp = redPlayer.Move(MoveEnum.Ahead);
                    if (board.ReservePoint(temp) == false)
                    {
                        redPlayer.IsDead = true;
                    }
                    cntRed++;
                    cntRed++;
                }

                if (cntBlue >= MovesBlue[cntBlue])
                {

                }
                else if (MovesBlue[cntBlue] == 'M')
                {
                    temp = bluePlayer.Move(MoveEnum.Ahead);
                    if (board.ReservePoint(temp) == false)
                    {
                        bluePlayer.IsDead = true;
                    }
                    cntBlue++;
                }
                else if (MovesBlue[cntBlue] == 'L')
                {
                    bluePlayer.Move(MoveEnum.Left);
                    temp = bluePlayer.Move(MoveEnum.Ahead);
                    if (board.ReservePoint(temp) == false)
                    {
                        bluePlayer.IsDead = true;
                    }
                    cntBlue++;
                    cntBlue++;
                }
                else if (MovesBlue[cntBlue] == 'R')
                {
                    bluePlayer.Move(MoveEnum.Right);
                    temp = bluePlayer.Move(MoveEnum.Ahead);
                    if (board.ReservePoint(temp) == false)
                    {
                        bluePlayer.IsDead = true;
                    }
                    cntBlue++;
                    cntBlue++;
                }

                //   Console.WriteLine(board);
                //   Console.ReadLine();

                if (redPlayer.Position.X == bluePlayer.Position.X && redPlayer.Position.Y == bluePlayer.Position.Y)
                {
                    Console.WriteLine("DRAW");
                    int ret = Math.Abs(redPlayer.Position.X - redPlayer.startPosition.X) + Math.Abs(redPlayer.Position.Y - redPlayer.startPosition.Y);
                    Console.WriteLine(ret);
                    return;
                }
                else if (redPlayer.IsDead == true)
                {
                    Console.WriteLine("BLUE");
                    int ret = Math.Abs(redPlayer.Position.X - redPlayer.startPosition.X) + Math.Abs(redPlayer.Position.Y - redPlayer.startPosition.Y);
                    Console.WriteLine(ret);
                    return;
                }
                else if (bluePlayer.IsDead == true)
                {
                    Console.WriteLine("RED");
                    int ret = Math.Abs(redPlayer.Position.X - redPlayer.startPosition.X) + Math.Abs(redPlayer.Position.Y - redPlayer.startPosition.Y);
                    Console.WriteLine(ret);
                    return;
                }
            }
        }
    }
}
