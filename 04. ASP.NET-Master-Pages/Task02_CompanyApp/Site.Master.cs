using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task02_CompanyApp
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DropDownList1.SelectedIndex == 0)
            {
                Response.Redirect("~/BG/Home.aspx");
            }
            else if (this.DropDownList1.SelectedIndex == 1)
            {
                Response.Redirect("~/EN/Home.aspx");
            }
            else if (this.DropDownList1.SelectedIndex == 2)
            {
                Response.Redirect("~/DE/Home.aspx");
            }
        }
    }
}