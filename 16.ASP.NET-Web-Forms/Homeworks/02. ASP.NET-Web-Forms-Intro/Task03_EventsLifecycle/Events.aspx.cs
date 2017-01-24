namespace Task03_EventsLifecycle
{
    using System;

    public partial class Events : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreInit invoked" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Write("Page_Init invoked" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Page_Load invoked" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreRender invoked" + "<br/>");
        }

        protected void LabelTest_DataBinding(object sender, EventArgs e)
        {
            this.Response.Write("LabelTest_DataBinding invoked" + "<br/>");
        }

        protected void LabelTest_Disposed(object sender, EventArgs e)
        {
            this.Response.Write("LabelTest_Disposed invoked" + "<br/>");
        }

        protected void LabelTest_Init(object sender, EventArgs e)
        {
            this.Response.Write("LabelTest_Init invoked" + "<br/>");
        }

        protected void LabelTest_Load(object sender, EventArgs e)
        {
            this.Response.Write("LabelTest_Load invoked" + "<br/>");
        }

        protected void LabelTest_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("LabelTest_PreRender invoked" + "<br/>");
        }

        protected void LabelTest_Unload(object sender, EventArgs e)
        {
            //this.Response.Write("LabelTest_Unload invoked" + "<br/>");
        }
    }
}