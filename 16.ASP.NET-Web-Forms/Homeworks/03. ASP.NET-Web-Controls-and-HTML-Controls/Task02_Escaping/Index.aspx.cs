using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task02_Escaping
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEscape_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text = Server.HtmlEncode(this.TextBoxInput.Text);
        }
    }
}