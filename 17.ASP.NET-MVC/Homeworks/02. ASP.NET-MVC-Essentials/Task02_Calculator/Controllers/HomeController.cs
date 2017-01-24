using System.Web.Mvc;
using Task02_Calculator.Models;

namespace Task02_Calculator.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View(new CalculatorViewModel());
        }

        [HttpPost]
        public ActionResult Index(CalculatorViewModel data)
        {
            data.UpdateData();
            return View(data);
        }
     
    }
}