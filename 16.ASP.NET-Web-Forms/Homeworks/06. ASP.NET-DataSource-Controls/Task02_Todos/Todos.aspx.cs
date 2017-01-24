using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task02_Todos.Data;

namespace Task02_Todos
{
    public partial class Categories : System.Web.UI.Page
    {
        TodosDbContext db = new TodosDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<Category> ListViewCategories_SelectItem()
        {
            return db.Category;
        }

        public IQueryable<Todo> ListViewTodos_SelectItem()
        {
            return db.Todo;
        }

        public void ListViewCategories_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.db.Category.Add(item);
                    this.db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                   // this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        public void ListViewCategories_UpdateItem(int id)
        {
            Category item = this.db.Category.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    //this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        public void ListViewTodos_UpdateItem(int id)
        {
            DropDownList DropDownListCat = null;

            foreach (ListViewDataItem control in this.ListViewTodo.Items)
            {
                DropDownListCat = (DropDownList)control.FindControl("DropDownListCategories");
                
                if (DropDownListCat != null)
                {
                    break;
                }
            }
            
            Todo item = this.db.Todo.Find(id);
            Category cat = this.db.Category.FirstOrDefault(c => c.Name == DropDownListCat.SelectedValue);

            // item.Category = this.ListViewTodo
            if (item == null || cat == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            item.Category = cat;
            item.DateChanged = DateTime.Now;

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    //this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        public void ListViewTodos_InsertItem()
        {
            DropDownList ddl = (DropDownList)ListViewTodo.InsertItem.FindControl("DropDownAddCategories");

            var item = new Todo();
            Category cat = this.db.Category.FirstOrDefault(c => c.Name == ddl.SelectedValue);
            TryUpdateModel(item);

            item.Category = cat;
            item.DateChanged = DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {
                    this.db.Todo.Add(item);
                    this.db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    // this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        public void ListViewTodos_DeleteItem(int id)
        {
            Todo item = this.db.Todo.Find(id);
            this.db.Todo.Remove(item);
            this.db.SaveChanges();
        }


        public void ListViewCategories_DeleteItem(int id)
        {
            Category item = this.db.Category.Find(id);
            this.db.Category.Remove(item);
            this.db.SaveChanges();
        }

    }
}