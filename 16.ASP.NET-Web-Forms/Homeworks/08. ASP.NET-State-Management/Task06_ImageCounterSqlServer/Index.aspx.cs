using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task06_ImageCounterSqlServer.Migrations;

namespace Task06_ImageCounterSqlServer
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelUsersDbContext, Configuration>());

            ModelUsersDbContext db = new ModelUsersDbContext();
            var userEntry = db.User.FirstOrDefault(u => u.Name == "Counter");

            if (userEntry != null)
            {
                userEntry.Count += 1;
            
                var img = ImageConverter.CreateBitmapImage("Total users: " + userEntry.Count.ToString());
                img.Save(this.Response.OutputStream, ImageFormat.Jpeg);
                this.Response.ContentType = "image/png";

                db.SaveChanges();
            }            
        }
    }
}