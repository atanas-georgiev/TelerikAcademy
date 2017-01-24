using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task01_NothwindAjax
{
    public partial class Index : System.Web.UI.Page
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        private int? selectedId = null;

        protected void Page_Load(object sender, EventArgs e)
        {            
        
        }
        public IQueryable<Employee> GridViewEmployees_Select()
        {
            return db.Employees.OrderBy(e => e.EmployeeID);
        }

        public IQueryable<Order> GridViewOrders_Select()
        {
            if (selectedId != null)
            {                
                return
                    db.Orders.OrderBy(o => o.OrderID)
                        .Where(o => o.EmployeeID == selectedId);
            }
            else
            {
                return null;
            }
        }

        protected void GridViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            selectedId = this.GridViewEmployees.SelectedIndex;
            this.GridViewOrders.DataBind();
        }
    }
}