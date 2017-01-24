namespace Task03_HttpHandler
{    
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Web;

    public class TextAsPngImage : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Enter some text in url => http://localhost:65196/sometext
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            var requestUrl = context.Request.Url.ToString();

            var path = context.Server.MapPath("images/image.png");
            var bitmap = new Bitmap(400, 150, PixelFormat.Format24bppRgb);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var backgroundColor = Color.Bisque;
                graphics.Clear(backgroundColor);
                graphics.DrawString(
                    requestUrl,
                    new Font("Arial", 14, FontStyle.Bold),
                    SystemBrushes.WindowText,
                    new PointF(10, 40));
                context.Response.ContentType = "image/png";
                bitmap.Save(context.Response.OutputStream, ImageFormat.Png);
            }
        }
    }
}