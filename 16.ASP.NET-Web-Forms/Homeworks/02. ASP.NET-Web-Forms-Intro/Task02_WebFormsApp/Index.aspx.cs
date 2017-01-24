namespace Task02_WebFormsApp
{
    using System;
    using System.Reflection;

    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LabelCode.Text = "Hello from code behind!";
            var location = Assembly.GetExecutingAssembly().Location;
            this.LabelLocation.Text = "This application is executed from " + location;
        }
    }
}