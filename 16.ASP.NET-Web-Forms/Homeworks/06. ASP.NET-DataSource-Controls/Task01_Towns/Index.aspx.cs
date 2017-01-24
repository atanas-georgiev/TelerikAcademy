using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task01_Towns.Data;

namespace Task01_Towns
{
    public partial class Index : System.Web.UI.Page
    {
        TownsDbContext db = new TownsDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Continent> ListBoxContinents_Select()
        {
            return db.Continents.OrderBy(c => c.Id);
        }

        protected void ButtonDeleteContinent_OnClick(object sender, EventArgs e)
        {
            Continent item = this.db.Continents.FirstOrDefault(c => c.Name == this.ListBoxContinents.SelectedValue);
            if (item != null)
            {
                this.db.Continents.Remove(item);
                this.db.SaveChanges();
                this.ListBoxContinents.DataBind();
            }
        }

        protected void ButtonAddContinent_OnClick(object sender, EventArgs e)
        {
            var item = new Continent();
            item.Name = this.TextBoxAddContinent.Text;
            db.Continents.Add(item);
            db.SaveChanges();

            this.ListBoxContinents.DataBind();
        }

        protected void ListBoxContinents_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        public IQueryable<Country> GridViewCountries_Select()
        {
            return db.Countries;
        }

        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        protected void ButtonAddCountry_OnClick(object sender, EventArgs e)
        {
            var item = new Country();
            item.Name = this.TextBoxAddCountryName.Text;
            item.Language = this.TextBoxAddCountryLanguage.Text;
            item.Population = int.Parse(this.TextBoxAddCountryPopulation.Text);

            if (this.FileUploadFlagData.HasFile)
            {
                byte[] fileData = null;
                Stream fileStream = null;
                int length = 0;

                length = FileUploadFlagData.PostedFile.ContentLength;
                fileData = new byte[length + 1];
                fileStream = FileUploadFlagData.PostedFile.InputStream;
                fileStream.Read(fileData, 0, length);

                fileStream.Seek(0, SeekOrigin.Begin);

                item.Flag = ReadFully(fileStream);
            }

            var continent = this.db.Continents.FirstOrDefault(c => c.Name == this.DropDownListContinents.SelectedValue);
            item.ContinentId = continent.Id;

            db.Countries.Add(item);            
            db.SaveChanges();

            this.GridViewCountries.DataBind();
        }
        public void GridViewCountries_UpdateItem(int id)
        {
            Country item = this.db.Countries.Find(id);

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

        public void GridViewCountries_DeleteItem(int id)
        {
            Country item = this.db.Countries.Find(id);
            db.Countries.Remove(item);
            db.SaveChanges();
        }

        public IQueryable<Town> ListViewTowns_SelectItem()
        {
            return db.Towns;
        }

        public void ListViewTowns_InsertItem()
        {
            var item = new Town();

            DropDownList ddl = (DropDownList)ListViewTowns.InsertItem.FindControl("DropDownListAddCountries");
            Country count = this.db.Countries.FirstOrDefault(c => c.Name == ddl.SelectedValue);
            TryUpdateModel(item);

            item.Country = count;

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.db.Towns.Add(item);
                    this.db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    // this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        public void ListViewTowns_UpdateItem(int id)
        {            
            DropDownList ddl = (DropDownList)this.ListViewTowns.Items[0].FindControl("DropDownListCountries");
            Country count = this.db.Countries.FirstOrDefault(c => c.Name == ddl.SelectedValue);

            Town item = this.db.Towns.Find(id);
            item.CountryId = count.Id;

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

        public void ListViewTowns_DeleteItem(int id)
        {
            Town item = this.db.Towns.Find(id);
            this.db.Towns.Remove(item);
            this.db.SaveChanges();
        }
    }
}