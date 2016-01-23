using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task01_CarLibrary.Data;
using System.Linq;

namespace Task01_CarLibrary
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.DropDownListProducers.DataSource = CarsData.Producers;
                this.DropDownListProducers.DataBind();
                this.DropDownListModels.DataSource = CarsData.Producers[0].Models;
                this.DropDownListModels.DataBind();
                this.CheckBoxListExtras.DataSource = CarsData.Extras;
                this.CheckBoxListExtras.DataBind();
                this.RadioButtonListEngine.DataSource = CarsData.EngineType;
                this.RadioButtonListEngine.DataBind();
            }

            this.LiteralSelected.Text = "Car: " + this.DropDownListProducers.SelectedValue + " " +
                                        this.DropDownListModels.SelectedValue + "<br>" +
                                        "Engine: " + this.RadioButtonListEngine.SelectedValue + "<br>" +
                                        "Extras: ";

            foreach (ListItem item in CheckBoxListExtras.Items)
            {
                if (item.Selected)
                {
                    this.LiteralSelected.Text += item.Text + "<br>";
                }
            }

        }

        protected void DropDownListProducers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProducer =
                CarsData.Producers.FirstOrDefault(x => x.Name == this.DropDownListProducers.SelectedValue);
            this.DropDownListModels.DataSource = selectedProducer.Models;
            this.DropDownListModels.DataBind();
        }
    }
}