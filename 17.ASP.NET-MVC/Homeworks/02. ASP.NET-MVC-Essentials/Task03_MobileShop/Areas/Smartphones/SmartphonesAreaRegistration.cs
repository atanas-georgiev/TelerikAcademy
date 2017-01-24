using System.Web.Mvc;

namespace Task03_MobileShop.Areas.Smartphones
{
    public class SmartphonesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Smartphones";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Smartphones_default",
                "Smartphones/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}