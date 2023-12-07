using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;
using Microsoft.EntityFrameworkCore;

namespace InternetGameBlog.Web.Controllers
{
    public class PlatformController : Controller
    {
        private readonly GameBlogDbContext dbContext; 
        public PlatformController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public async Task<IActionResult> Index()
        {
            var platforms = await dbContext.Platforms.ToListAsync();
            return View(platforms);
        }
    }
}
