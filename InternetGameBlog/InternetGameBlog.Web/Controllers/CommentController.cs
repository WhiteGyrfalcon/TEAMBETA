using Microsoft.AspNetCore.Mvc;

namespace InternetGameBlog.Web.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
