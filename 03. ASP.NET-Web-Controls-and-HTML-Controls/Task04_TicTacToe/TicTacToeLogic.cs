namespace Task04_TicTacToe
{
    using System;
    
    public class TicTacToeLogic
    {
        public const int MaxX = 3;
        public const int MaxY = 3;

        public int[,] GameBoard;

        public TicTacToeLogic()
        {
            GameBoard = new int[MaxX,MaxY];
        }

        public void FirstPlayerMove(int x, int y)
        {
            if (GameBoard[x, y] != 0)
            {
                throw new InvalidOperationException("Not valid move!");
            }

            GameBoard[x, y] = 1;
        }

        public void SecondPlayerMove(int x, int y)
        {
            if (GameBoard[x, y] != 0)
            {
                throw new InvalidOperationException("Not valid move!");
            }

            GameBoard[x, y] = 2;
        }

        public bool IsGameFinished()
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                var foundEmpty = false;

                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if (GameBoard[i, j] == 0)
                    {
                        foundEmpty = true;
                        break;
                    }
                }

                if (foundEmpty == false)
                {
                    return true;
                }
            }

            for (int i = 0; i < GameBoard.GetLength(1); i++)
            {
                var foundEmpty = false;

                for (int j = 0; j < GameBoard.GetLength(0); j++)
                {
                    if (GameBoard[j, i] == 0)
                    {
                        foundEmpty = true;
                        break;
                    }
                }

                if (foundEmpty == false)
                {
                    return true;
                }
            }

            return false;            
        }
    }
}