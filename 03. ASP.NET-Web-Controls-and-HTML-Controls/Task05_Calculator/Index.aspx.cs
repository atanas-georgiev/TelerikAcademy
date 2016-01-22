namespace Task05_Calculator
{
    using System;

    public partial class Index : System.Web.UI.Page
    {
        void AppendSymbol(char c)
        {
            this.TextBoxCalculator.Text += c.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AppendSymbol('1');
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AppendSymbol('2');
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            AppendSymbol('3');
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            AppendSymbol('4');
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            AppendSymbol('5');
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            AppendSymbol('6');
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            AppendSymbol('7');
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            AppendSymbol('8');
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            AppendSymbol('9');
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            if (this.TextBoxCalculator.Text != string.Empty)
            {
                AppendSymbol('0');
            }            
        }

        private void DoCalculation()
        {
            if (Session["number"] != null && Session["operation"] != null)
            {
                if (this.TextBoxCalculator.Text == string.Empty)
                {
                    this.TextBoxCalculator.Text = "0";
                }

                double result = 0;
                switch ((char)Session["operation"])
                {
                    case '+':
                        result = double.Parse(Session["number"].ToString()) +
                                 double.Parse(this.TextBoxCalculator.Text);                        
                        break;
                    case '-':
                        result = double.Parse(Session["number"].ToString()) -
                                 double.Parse(this.TextBoxCalculator.Text);
                        break;
                    case '*':
                        result = double.Parse(Session["number"].ToString()) *
                                 double.Parse(this.TextBoxCalculator.Text);
                        break;
                    case '/':                        
                        result = double.Parse(Session["number"].ToString()) /
                                 double.Parse(this.TextBoxCalculator.Text);
                        break;

                }

                this.TextBoxCalculator.Text = result.ToString();
                Session["number"] = null;
                Session["operation"] = null;
            }
        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (this.TextBoxCalculator.Text == string.Empty)
            {
                this.TextBoxCalculator.Text = "0";
            }

            Session["number"] = this.TextBoxCalculator.Text;
            Session["operation"] = '+';
            this.TextBoxCalculator.Text = string.Empty;
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (this.TextBoxCalculator.Text == string.Empty)
            {
                this.TextBoxCalculator.Text = "0";
            }

            Session["number"] = this.TextBoxCalculator.Text;
            Session["operation"] = '-';
            this.TextBoxCalculator.Text = string.Empty;
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (this.TextBoxCalculator.Text == string.Empty)
            {
                this.TextBoxCalculator.Text = "0";
            }

            Session["number"] = this.TextBoxCalculator.Text;
            Session["operation"] = '*';
            this.TextBoxCalculator.Text = string.Empty;
        }

        protected void ButtonDevide_Click(object sender, EventArgs e)
        {
            if (this.TextBoxCalculator.Text == string.Empty)
            {
                this.TextBoxCalculator.Text = "0";
            }

            Session["number"] = this.TextBoxCalculator.Text;
            Session["operation"] = '/';
            this.TextBoxCalculator.Text = string.Empty;
        }

        protected void ButtonSquare_Click(object sender, EventArgs e)
        {
            if (this.TextBoxCalculator.Text == string.Empty)
            {
                this.TextBoxCalculator.Text = "0";
            }

            var result = Math.Sqrt(double.Parse(TextBoxCalculator.Text));
            this.TextBoxCalculator.Text = result.ToString();
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            Session["number"] = this.TextBoxCalculator.Text;
            Session["operation"] = '*';
            this.TextBoxCalculator.Text = string.Empty;
        }
    }
}