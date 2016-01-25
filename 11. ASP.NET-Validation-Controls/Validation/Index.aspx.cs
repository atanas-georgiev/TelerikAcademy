using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckInterests();
        }

        protected void RadioButtonListGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInterests();
        }

        public void CheckInterests()
        {
            if (this.RadioButtonListGender.SelectedIndex == 0)
            {
                this.PanelMale.Visible = true;
                this.PanelFemale.Visible = false;
            }
            else
            {
                this.PanelMale.Visible = false;
                this.PanelFemale.Visible = true;
            }
        }
    }
}