using Microsoft.AspNetCore.Mvc;
using InternetGameBlog.Data;
using Microsoft.EntityFrameworkCore;
using InternetGameBlog.Web.ViewModels.Platform;
using InternetGameBlog.Data.Models;
using InternetGameBlog.Web.ViewModels.Game;

namespace InternetGameBlog.Web.Controllers
{
    public class PlatformController : Controller
    {
        private readonly GameBlogDbContext dbContext; 
        public PlatformController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var platforms = await dbContext.Platforms.ToListAsync();
            return View(platforms);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return await Task.Run(() => View("Add"));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPlatformViewModel viewModel)
        {
            Platform platform = new Platform()
            { Name = viewModel.Name };

            await dbContext.Platforms.AddAsync(platform);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var platform = await dbContext.Platforms.FirstOrDefaultAsync(x => x.Id == id);
            if (platform != null)
            {
                EditPlatformViewModel viewModel = new EditPlatformViewModel()
                {
                    Name = platform.Name,
                    Games = platform.Games
                };

                return await Task.Run(() => View("Edit", viewModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditPlatformViewModel viewModel)
        {
            Platform platform = await dbContext.Platforms.FindAsync(viewModel.Id);
            if (platform != null)
            {
                platform.Name = viewModel.Name;
                platform.Games = viewModel.Games;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
