using System.Collections.Generic;
using System.Web.Mvc;
using Task03_MobileShop.Areas.Smartphones.Models;

namespace Task03_MobileShop.Areas.Smartphones.Controllers
{
    public class IndexController : Controller
    {

        IEnumerable<SmarthoneViewModel> smartphones = new List<SmarthoneViewModel>()
        {
            new SmarthoneViewModel()
            {
                Manufacturer = "Apple",
                Model = "IPhone6s",
                Url = "https://ss7.vzw.com/is/image/VerizonWireless/landing-page-why-vz-iphone-6s-plus-homescreen-v1?$defaultScaleJPG90$",
                Info = "Some info about the phone"
            },
            new SmarthoneViewModel()
            {
                Manufacturer = "Samsung",
                Model = "S6 Edge",
                Url = "http://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s6-edge-4.jpg",
                Info = "Some info about the phone"
            },
            new SmarthoneViewModel()
            {
                Manufacturer = "Nokia",
                Model = "950",
                Url = "http://www.windowscentral.com/sites/wpcentral.com/files/styles/large/public/topic_images/2015/lumia-950-topic-screen.png?itok=4nxRoI3g",
                Info = "Some info about the phone"
            }
        };

        // GET: Smartphones/Index
        public ActionResult Index()
        {
            return View(smartphones);
        }
    }
}