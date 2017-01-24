namespace Task02_SumatorWebForms
{
    using System;

    public partial class Sumator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSum_Click(object sender, EventArgs e)
        {
            var sum = int.Parse(this.TextBoxFirst.Text) + int.Parse(this.TextBoxSecond.Text);
            this.TextBoxResult.Text = sum.ToString();
        }
    }
}