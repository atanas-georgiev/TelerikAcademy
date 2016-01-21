namespace Task01_Random
{
    using System;
    
    public partial class Random : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRandom_OnServerClick(object sender, EventArgs e)
        {
            var firstValue = int.Parse(this.TextHtmlRandomFirst.Value);
            var secondValue = int.Parse(this.TextHtmlRandomSecond.Value);
            var rand = new System.Random();
            var random = rand.Next(firstValue, secondValue + 1);

            this.labelResult.InnerText = random.ToString();
        }
    }
}