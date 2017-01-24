using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task04_TicTacToe
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["game"] == null)
            {
                Session["game"] = new TicTacToeLogic();
            }
        }

        private void UpdateGameData()
        {
            var game = (TicTacToeLogic) Session["game"];

            if (game.GameBoard[0, 0] != ' ')
            {
                this.Button1_1.Enabled = false;
            }

            if (game.GameBoard[0, 1] != ' ')
            {
                this.Button1_2.Enabled = false;
            }

            if (game.GameBoard[0, 2] != ' ')
            {
                this.Button1_3.Enabled = false;
            }

            if (game.GameBoard[1, 0] != ' ')
            {
                this.Button2_1.Enabled = false;
            }

            if (game.GameBoard[1, 1] != ' ')
            {
                this.Button2_2.Enabled = false;
            }

            if (game.GameBoard[1, 2] != ' ')
            {
                this.Button2_3.Enabled = false;
            }

            if (game.GameBoard[2, 0] != ' ')
            {
                this.Button3_1.Enabled = false;
            }

            if (game.GameBoard[2, 1] != ' ')
            {
                this.Button3_2.Enabled = false;
            }

            if (game.GameBoard[2, 2] != ' ')
            {
                this.Button3_3.Enabled = false;
            }

            this.Button1_1.Text = game.GameBoard[0, 0].ToString();
            this.Button1_2.Text = game.GameBoard[0, 1].ToString();
            this.Button1_3.Text = game.GameBoard[0, 2].ToString();
            this.Button2_1.Text = game.GameBoard[1, 0].ToString();
            this.Button2_2.Text = game.GameBoard[1, 1].ToString();
            this.Button2_3.Text = game.GameBoard[1, 2].ToString();
            this.Button3_1.Text = game.GameBoard[2, 0].ToString();
            this.Button3_2.Text = game.GameBoard[2, 1].ToString();
            this.Button3_3.Text = game.GameBoard[2, 2].ToString();
        }

        protected void Button1_1_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(0, 0);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button1_2_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(0, 1);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button1_3_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(0, 2);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button2_1_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(1, 0);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button2_2_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(1, 1);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button2_3_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(1, 2);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button3_1_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(2, 0);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button3_2_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(2, 1);
            if (IsGameOver())
            {
                PlayerWins();
                return;
            }
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        protected void Button3_3_Click(object sender, EventArgs e)
        {
            var game = (TicTacToeLogic) Session["game"];
            game.FirstPlayerMove(2, 2);
            game.ComputerPlayerMove();
            if (IsGameOver())
            {
                ComputerWins();
                return;
            }
            Session["game"] = game;
            UpdateGameData();
        }

        private bool IsGameOver()
        {
            var game = (TicTacToeLogic)Session["game"];
            var gameResult = game.IsGameFinished();
            if (gameResult == -1)
            {
                return false;
            }
            return true;
        }

        private void PlayerWins()
        {
            LiteralResult.Text = "You win!";
            Session["game"] = new TicTacToeLogic();
            UpdateGameData();
        }

        private void ComputerWins()
        {
            LiteralResult.Text = "You loose!";
            Session["game"] = new TicTacToeLogic();
            UpdateGameData();
        }

        protected void ButtonNewGame_Click(object sender, EventArgs e)
        {
            LiteralResult.Text = "";
            Session["game"] = new TicTacToeLogic();
            this.Button1_1.Enabled = true;
            this.Button1_2.Enabled = true;
            this.Button1_3.Enabled = true;
            this.Button2_1.Enabled = true;
            this.Button2_2.Enabled = true;
            this.Button2_3.Enabled = true;
            this.Button3_1.Enabled = true;
            this.Button3_2.Enabled = true;
            this.Button3_3.Enabled = true;
            UpdateGameData();
        }
    }
}