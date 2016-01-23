using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task02_Employes_GridView
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("EmpDetails.aspx?id=" + this.GridViewEmployees.SelectedIndex);
        }
    }
}