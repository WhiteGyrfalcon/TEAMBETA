using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;

namespace InternetGameBlog.Web.Controllers
{
    public class PlatformController : Controller
    {
        private readonly GameBlogDbContext dbContext; 
        public PlatformController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
