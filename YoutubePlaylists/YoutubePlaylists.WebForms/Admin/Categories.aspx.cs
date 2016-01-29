using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;

namespace YoutubePlaylists.WebForms.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        GenericRepository<Category> categories = new GenericRepository<Category>(); 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GridViewCategories_SelectItem()
        {
            return categories.All().OrderBy(c => c.Id); ;
        }

        public void GridViewCategories_UpdateItem(int id)
        {
            var category = categories.All().FirstOrDefault(c => c.Id == id);

            if (category != null)
            {
                TryUpdateModel(category);

                if (ModelState.IsValid)
                {
                    try
                    {
                        categories.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        CustomValidator.IsValid = false;
                        CustomValidator.ErrorMessage = $"Category {category.Name} already exists";
                    }
                }
            }
            this.GridViewCategories.DataBind();
        }

        public void GridViewCategories_DeleteItem(int id)
        {
            try
            {
                categories.Delete(id);
                categories.SaveChanges();
            }
            catch (Exception)
            {
                CustomValidator.IsValid = false;
                CustomValidator.ErrorMessage = "Error during update";
            }
            this.GridViewCategories.DataBind();
        }

        protected void ButtonInsertCategory_OnClick(object sender, EventArgs e)
        {
            var newCategory = new Category()
            {
                Name = this.TextBoxNewCategory.Text
            };

            try
            {
                categories.Add(newCategory);
                categories.SaveChanges();
            }
            catch (Exception)
            {
                CustomValidator.IsValid = false;
                CustomValidator.ErrorMessage = $"Category {newCategory.Name} already exists";
            }
            this.GridViewCategories.DataBind();
        }

        protected void ButtonCancel_OnClick(object sender, EventArgs e)
        {
            this.TextBoxNewCategory.Text = string.Empty;
        }
    }
}