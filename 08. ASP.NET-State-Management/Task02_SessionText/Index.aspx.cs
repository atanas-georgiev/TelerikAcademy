using System;
using System.Collections;
using System.Collections.Generic;

namespace Task02_SessionText
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["input"] == null)
            {
                Session["input"] = new List<string>();
            }            
        }

        protected void ButtonInput_Click(object sender, EventArgs e)
        {
            this.LabelResult.Text = "You have entered: " + this.TextBoxInput.Text;
            (Session["input"] as List<string>).Add(this.TextBoxInput.Text);
            this.ListViewSessionResult.DataBind();
        }

        public IEnumerable<string> Select()
        {
            return Session["input"] as List<string>;
        }
    }
}