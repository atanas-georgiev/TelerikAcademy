namespace Task01_Random
{
    using System;

    public partial class RandomAsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonAspRandom_Click(object sender, EventArgs e)
        {
            var firstValue = int.Parse(this.TextBoxFirstNumber.Text);
            var secondValue = int.Parse(this.TextBoxSecondNumber.Text);
            var rand = new System.Random();
            var random = rand.Next(firstValue, secondValue + 1);

            this.LabelAspResult.Text = random.ToString();
        }
    }
}