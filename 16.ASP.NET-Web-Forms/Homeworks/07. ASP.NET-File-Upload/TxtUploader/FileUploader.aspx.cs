using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TxtUploader.Models;

namespace TxtUploader
{
    public partial class FileUploader : System.Web.UI.Page
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            byte[] fileData = null;
            Stream fileStream = null;
            int length = 0;

            if (FileUploadZipData.HasFile)
            {
                try
                {
                    if (FileUploadZipData.PostedFile.ContentType == "application/x-zip-compressed")
                    {
                        length = FileUploadZipData.PostedFile.ContentLength;
                        fileData = new byte[length + 1];
                        fileStream = FileUploadZipData.PostedFile.InputStream;
                        fileStream.Read(fileData, 0, length);

                        fileStream.Seek(0, SeekOrigin.Begin);

                        using (var zip = new ZipArchive(fileStream, ZipArchiveMode.Read))
                        {
                            foreach (ZipArchiveEntry entry in zip.Entries)
                            {
                                TxtModel model = new TxtModel();
                                var zipFileStream = entry.Open();
                                model.FileContent = ReadFully(zipFileStream);                                
                                model.FileName = entry.FullName;
                                this.LiteralResult.Text += "File" + entry.FullName + " added to database";
                                db.TxtModel.Add(model);
                                db.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        this.LiteralResult.Text = "Please upload zip file!";
                    }
                }
                catch (Exception err)
                {
                    this.LiteralResult.Text = err.Message;
                }
            }
        }
    }
}