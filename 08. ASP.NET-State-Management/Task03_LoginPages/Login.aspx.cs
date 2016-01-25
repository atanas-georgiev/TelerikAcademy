using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task03_LoginPages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_OnClick(object sender, EventArgs e)
        {
            var cookie = new HttpCookie("UserName", this.TextBoxInput.Text);
            cookie.Expires = DateTime.Now.AddMinutes(1);

            Response.Cookies.Add(cookie);
            Response.Redirect("~/Secure.aspx");
        }
    }
}