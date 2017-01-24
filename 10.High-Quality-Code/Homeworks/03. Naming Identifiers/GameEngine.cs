// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameEngine.cs" company="n/a">
//   MineSweeper game
// </copyright>
// <summary>
//   Game engine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The mine.
    /// </summary>
    public class GameEngine
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="arguments">
        /// The arguments.
        /// </param>
        private static void Main(string[] arguments)
        {
            var currentCommand = string.Empty;
            var gameField = CreateField();
            var bombs = CreateBombs();
            var moves = 0;
            var isDoomed = false;
            var players = new List<Player>(6);
            var row = 0;
            var col = 0;
            var isNewGame = true;
            const int MaximumMoves = 35;
            var areMaximumMovesReached = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(
                        "Welcome to \"MineSweeper\". You have to find the cells with no bombs inside. "
                        + "Game commands: 'top' - show current results, 'restart - starts new game, exit - exits the game");
                    DisplayBoard(gameField);
                    isNewGame = false;
                }

                Console.Write("Enter row and column: ");
                currentCommand = Console.ReadLine().Trim();

                if (currentCommand.Length >= 3)
                {
                    if (int.TryParse(currentCommand[0].ToString(), out row)
                        && int.TryParse(currentCommand[2].ToString(), out col) && row <= gameField.GetLength(0)
                        && col <= gameField.GetLength(1))
                    {
                        currentCommand = "turn";
                    }
                }

                switch (currentCommand)
                {
                    case "top":
                        DisplayResult(players);
                        break;
                    case "restart":
                        gameField = CreateField();
                        bombs = CreateBombs();
                        DisplayBoard(gameField);
                        isDoomed = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye life, bye, bye happiness!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                Move(gameField, bombs, row, col);
                                moves++;
                            }

                            if (MaximumMoves == moves)
                            {
                                areMaximumMovesReached = true;
                            }
                            else
                            {
                                DisplayBoard(gameField);
                            }
                        }
                        else
                        {
                            isDoomed = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (isDoomed)
                {
                    DisplayBoard(bombs);
                    Console.Write("\nHrrrrrr! You died! Your score is {0} points. " + "Enter you nickname: ", moves);
                    var name = Console.ReadLine();
                    var player = new Player(name, moves);

                    if (players.Count < 5)
                    {
                        players.Add(player);
                    }
                    else
                    {
                        for (var i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < player.Points)
                            {
                                players.Insert(i, player);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort(
                        (Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    players.Sort(
                        (Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    DisplayResult(players);

                    gameField = CreateField();
                    bombs = CreateBombs();
                    moves = 0;
                    isDoomed = false;
                    isNewGame = true;
                }

                if (areMaximumMovesReached)
                {
                    Console.WriteLine("\nCongratulations! You did 35 moves witout hitting a bomb!.");
                    DisplayBoard(bombs);
                    Console.WriteLine("Enter you nickname: ");

                    var name = Console.ReadLine();
                    var player = new Player(name, moves);
                    players.Add(player);
                    DisplayResult(players);
                    gameField = CreateField();
                    bombs = CreateBombs();
                    moves = 0;
                    areMaximumMovesReached = false;
                    isNewGame = true;
                }
            }
            while (currentCommand != "exit");

            Console.WriteLine("Made in Bulgaria - :)");
            Console.WriteLine("See ya!.");
            Console.Read();
        }

        /// <summary>
        /// The display result.
        /// </summary>
        /// <param name="players">
        /// The players.
        /// </param>
        private static void DisplayResult(List<Player> players)
        {
            Console.WriteLine("\nPoints: ");
            if (players.Count > 0)
            {
                for (var i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No players yet!\n");
            }
        }

        /// <summary>
        /// The move.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <param name="bombs">
        /// The bombs.
        /// </param>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="col">
        /// The col.
        /// </param>
        private static void Move(char[,] field, char[,] bombs, int row, int col)
        {
            var bombCount = GetCellBombs(bombs, row, col);
            bombs[row, col] = bombCount;
            field[row, col] = bombCount;
        }

        /// <summary>
        /// The DisplayBoard.
        /// </summary>
        /// <param name="board">
        /// The board.
        /// </param>
        private static void DisplayBoard(char[,] board)
        {
            var rows = board.GetLength(0);
            var cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (var i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (var j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        /// <summary>
        ///     The CreateField.
        /// </summary>
        /// <returns>
        ///     The <see cref="char[,]" />.
        /// </returns>
        private static char[,] CreateField()
        {
            var rows = 5;
            var cols = 10;
            var board = new char[rows, cols];
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        /// <summary>
        ///     The CreateBombs.
        /// </summary>
        /// <returns>
        ///     The <see cref="char[,]" />.
        /// </returns>
        private static char[,] CreateBombs()
        {
            var rows = 5;
            var cols = 10;
            var field = new char[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            var listBombs = new List<int>();
            while (listBombs.Count < 15)
            {
                var rand = new Random();
                var randNumber = rand.Next(50);
                if (!listBombs.Contains(randNumber))
                {
                    listBombs.Add(randNumber);
                }
            }

            foreach (var bomb in listBombs)
            {
                var currentCol = bomb / cols;
                var currentRow = bomb % cols;
                if (currentRow == 0 && bomb != 0)
                {
                    currentCol--;
                    currentRow = cols;
                }
                else
                {
                    currentRow++;
                }

                field[currentCol, currentRow - 1] = '*';
            }

            return field;
        }

        /// <summary>
        /// The calculate cell points.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        private static void CalculateCellPoints(char[,] field)
        {
            var kol = field.GetLength(0);
            var red = field.GetLength(1);

            for (var i = 0; i < kol; i++)
            {
                for (var j = 0; j < red; j++)
                {
                    if (field[i, j] != '*')
                    {
                        var kolkoo = GetCellBombs(field, i, j);
                        field[i, j] = kolkoo;
                    }
                }
            }
        }

        /// <summary>
        /// The get cell bombs.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="col">
        /// The col.
        /// </param>
        /// <returns>
        /// The <see cref="char"/>.
        /// </returns>
        private static char GetCellBombs(char[,] field, int row, int col)
        {
            var bombs = 0;
            var rows = field.GetLength(0);
            var cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    bombs++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    bombs++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    bombs++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    bombs++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    bombs++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    bombs++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    bombs++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    bombs++;
                }
            }

            return char.Parse(bombs.ToString());
        }
    }
}