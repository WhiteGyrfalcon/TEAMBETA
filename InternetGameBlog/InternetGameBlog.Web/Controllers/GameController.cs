using InternetGameBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace InternetGameBlog.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly GameBlogDbContext dbContext;
        public GameController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
