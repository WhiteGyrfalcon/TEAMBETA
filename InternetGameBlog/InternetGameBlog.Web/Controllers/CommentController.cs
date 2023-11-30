using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;

namespace InternetGameBlog.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly GameBlogDbContext dbContext;
        public CommentController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
