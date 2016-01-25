using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace Task05_WebCounter
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Users"] == null)
            {
                Application["Users"] = 0;
            }

            Application.Lock();
            Application["Users"] = (int)Application["Users"] + 1;
            Application.UnLock();

            Bitmap img = ImageConverter.CreateBitmapImage("Total users: " + Application["Users"].ToString());
            img.Save(this.Response.OutputStream, ImageFormat.Jpeg);
            this.Response.ContentType = "image/png";
        }
    }
}