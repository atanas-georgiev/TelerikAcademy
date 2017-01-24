using System.Collections.Generic;
using System.Web.Mvc;
using Task03_MobileShop.Areas.Laptops.Models;
using Task03_MobileShop.Areas.Smartphones.Models;

namespace Task03_MobileShop.Areas.Laptops.Controllers
{
    public class IndexController : Controller
    {
        IEnumerable<LaptopViewModel> laptops = new List<LaptopViewModel>()
        {
            new LaptopViewModel()
            {
                Manufacturer = "Acer",
                Model = "Aspire ES1-131",
                Url =
                    "http://www.pcstore.bg/media/catalog/product/cache/1/image/325x250/0dc2d03fe217f8c83829496872af24a0/n/x/nx.mygex.015_1_image.jpg",
                Info = "Some info about the laptop"
            },
            new LaptopViewModel()
            {
                Manufacturer = "HP",
                Model = "15 N6A60EA",
                Url = "http://www.pcstore.bg/media/catalog/product/cache/1/image/280x215/0dc2d03fe217f8c83829496872af24a0/n/6/n6a60ea_1_image.jpg",
                Info = "Some info about the laptop"
            },
            new LaptopViewModel()
            {
                Manufacturer = "Lenovo",
                Model = "100 80MJ00E5BM",
                Url =
                    "http://www.pcstore.bg/media/catalog/product/cache/1/image/325x250/0dc2d03fe217f8c83829496872af24a0/8/0/80mj00e5bm_1_image.jpg",
                Info = "Some info about the laptop"
            }
        };

        // GET: Smartphones/Index
        public ActionResult Index()
        {
            return View(laptops);
        }
    }
}