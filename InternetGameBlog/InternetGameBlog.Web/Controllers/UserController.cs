using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;
using Microsoft.EntityFrameworkCore;

namespace InternetGameBlog.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly GameBlogDbContext dbContext; 
        public UserController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        public async Task<IActionResult> Index()
        {
            var users = await dbContext.Users.ToListAsync();
            return View(users);
        }
    }
}
