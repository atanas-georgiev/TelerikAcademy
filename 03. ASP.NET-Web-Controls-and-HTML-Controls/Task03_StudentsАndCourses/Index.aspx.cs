using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task03_StudentsАndCourses
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_OnClick(object sender, EventArgs e)
        {
            var result = new StringBuilder();
            result.Append("<h1>Student name: " + this.TextBoxFirstName.Text + " " + this.TextBoxLastName.Text + "</h1>" +
                          "<h3>Facility number: " + this.TextBoxFacilityNumber.Text + "</h3>" +
                          "<h3>University: " + this.DropDownListUniversity.SelectedValue + "</h3>" +
                          "<h3>Specialty: " + this.DropDownListSpeciality.SelectedValue + "</h3>" +
                          "<strong>Courses: <br/>" +
                          "<ul>");
            
            foreach (ListItem item in this.CheckBoxListCourses.Items)
            {
                if (item.Selected)
                {
                    result.Append("<li>" + item.Text + "</li>");
                }
            }

            result.Append("</ul></strong>");

            this.LiteralResult.Text = result.ToString();
        }
    }
}