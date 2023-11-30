using Microsoft.AspNetCore.Mvc;

namespace InternetGameBlog.Web.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
