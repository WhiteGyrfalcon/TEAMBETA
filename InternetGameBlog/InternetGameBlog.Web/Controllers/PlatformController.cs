using Microsoft.AspNetCore.Mvc;

namespace InternetGameBlog.Web.Controllers
{
    public class PlatformController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
