using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;

namespace InternetGameBlog.Web.Controllers
{
    public class ImageController : Controller
    {
        private GameBlogDbContext dbContext;
        public ImageController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
    }
}
