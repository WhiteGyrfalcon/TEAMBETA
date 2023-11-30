using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;

namespace InternetGameBlog.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly GameBlogDbContext dbContext; 
        public UserController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
