using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task02_TodoList.Data;

namespace Task02_TodoList
{
    public partial class Index : System.Web.UI.Page
    {
        TodosDbContext db = new TodosDbContext();

        public Index()
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Todo> SelectAllData()
        {
            var items = db.Todo;
            return items;
        }

        public void Update()
        {
  
        }
    }
}