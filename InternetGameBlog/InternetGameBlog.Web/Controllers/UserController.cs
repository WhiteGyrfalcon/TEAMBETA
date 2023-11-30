using Microsoft.AspNetCore.Mvc;

namespace InternetGameBlog.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
