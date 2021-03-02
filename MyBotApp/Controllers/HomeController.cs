using System.Web.Mvc;

namespace MyBotApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "View(\"Hello Vasya\")";
        }
    }
}