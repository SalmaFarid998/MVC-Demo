using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello Content Result";
            //return result;

            //return Content("Hello from content result");

            //return Redirect("/Home/AboutUs");

            return View();
        }
        public ActionResult AboutUs()
        {
            //return "This is about us action";

            return View();
        }
        public ActionResult ContactUs()
        {
            //return "This is about us action";

            return View();
        }
        public ActionResult Privacy()
        {
            //return "This is about us action";

            return View();
        }
    }
}
