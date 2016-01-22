namespace Task04_TicTacToe
{
    using System;
    
    public class TicTacToeLogic
    {
        public const int MaxX = 3;
        public const int MaxY = 3;

        public char[,] GameBoard;

        public TicTacToeLogic()
        {
            GameBoard = new char[MaxX, MaxY];
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    GameBoard[i, j] = ' ';
                }
            }
        }

        public void FirstPlayerMove(int x, int y)
        {
            if (GameBoard[x, y] != ' ')
            {
                throw new InvalidOperationException("Not valid move!");
            }

            GameBoard[x, y] = 'X';
        }

        public void ComputerPlayerMove()
        {
            while (true)
            {
                Random rand1 = new Random();
                Random rand2 = new Random();

                var x = rand1.Next(MaxX);
                var y = rand2.Next(MaxY);

                if (this.GameBoard[x, y] == ' ')
                {
                    this.GameBoard[x, y] = 'O';
                    break;
                }
            }
        }

        public int IsGameFinished()
        {
            var cnt = 0;
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if (GameBoard[i, j] != ' ')
                    {
                        cnt ++;
                    }
                }
            }

            if (cnt == MaxX*MaxY)
            {
                return 0;
            }

            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                var foundEmpty = false;

                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if (GameBoard[i, j] == ' ')
                    {
                        foundEmpty = true;
                        break;
                    }
                }

                if (foundEmpty == false)
                {
                    return 1;
                }
            }

            for (int i = 0; i < GameBoard.GetLength(1); i++)
            {
                var foundEmpty = false;

                for (int j = 0; j < GameBoard.GetLength(0); j++)
                {
                    if (GameBoard[j, i] == ' ')
                    {
                        foundEmpty = true;
                        break;
                    }
                }

                if (foundEmpty == false)
                {
                    return 1;
                }
            }

            return -1;            
        }
    }
}