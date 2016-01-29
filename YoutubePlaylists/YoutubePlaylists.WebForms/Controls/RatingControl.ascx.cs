using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YoutubePlaylists.WebForms.Controls
{
    public class RatingEventArgs : EventArgs
    {
        public RatingEventArgs(object dataID, int ratingValue)
        {
            this.DataID = dataID;
            this.RatingValue = ratingValue;
        }

        public object DataID { get; set; }
        public int RatingValue { get; set; }
    }

    public partial class RatingControl : System.Web.UI.UserControl
    {
        public delegate void RatingEventHandler(object sender, RatingEventArgs e);

        public event RatingEventHandler Rate;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            this.Rate(this, new RatingEventArgs(e, 1));
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            this.Rate(this, new RatingEventArgs(e, 2));
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            this.Rate(this, new RatingEventArgs(e, 3));
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            this.Rate(this, new RatingEventArgs(e, 4));
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            this.Rate(this, new RatingEventArgs(e, 5));
        }
    }
}