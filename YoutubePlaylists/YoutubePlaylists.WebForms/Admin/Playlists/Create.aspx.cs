using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubePlaylists.Data.Models;
using YoutubePlaylists.Data.Repositories;

namespace YoutubePlaylists.WebForms.Admin.Playlists
{
    public partial class Create : System.Web.UI.Page
    {
        GenericRepository<Category> categories = new GenericRepository<Category>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> DropDownListCategory_Select()
        {
            return categories.All();
        }
    }
}