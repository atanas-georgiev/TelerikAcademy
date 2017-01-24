namespace Task01_HelloApp
{
    using System;

    public partial class HelloIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonHello_Click(object sender, EventArgs e)
        {
            this.LabelResult.Text = "Hello " + this.TextBoxName.Text + "!";
        }
    }
}