using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task03_LoginPages
{
    public partial class Secure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserName"];

            if (cookie != null)
            {
                string text = "You are allowed to view this page.";
                Response.Write(text);
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}