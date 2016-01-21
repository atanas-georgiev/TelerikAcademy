using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task04_TicTacToe
{
    public partial class Index : System.Web.UI.Page
    {
        TicTacToeLogic game = new TicTacToeLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < game.GameBoard.GetLength(0); i++)
            {
                dt.Columns.Add();             
            }

            for (int i = 0; i < game.GameBoard.GetLength(1); i++)
            {
                dt.Rows.Add();
            }

            for (int i = 0; i < game.GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < game.GameBoard.GetLength(1); j++)
                {
                    dt.Rows[i][j] = game.GameBoard[i, j];
                }

            }

            //arrList.Add(new ListItem(game.GameBoard[i, 0].ToString(), game.GameBoard[i, 1].ToString(), game.GameBoard[i, 2].ToString());
            //}

            GridViewGame.DataSource = dt;
            GridViewGame.DataBind();
        }

        protected void GridViewGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedRow = GridViewGame.SelectedRow.RowIndex;
            var SelectedColumn = GridViewGame.SelectedIndex;
        }

        protected void GridViewGame_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            var SelectedRow = GridViewGame.SelectedRow.RowIndex;
            var SelectedColumn = GridViewGame.SelectedIndex;
        }
    }
}