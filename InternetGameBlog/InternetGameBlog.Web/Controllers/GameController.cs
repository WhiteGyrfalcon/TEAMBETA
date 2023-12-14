using InternetGameBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InternetGameBlog.Web.ViewModels.Game;
using InternetGameBlog.Data.Models;

namespace InternetGameBlog.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly GameBlogDbContext dbContext;
        public GameController(GameBlogDbContext _context)
        {
            this.dbContext = _context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var games = await dbContext.Games.ToListAsync();
            return View(games);
        }

        [HttpGet]
        public async Task<IActionResult> FilterGamesByPlatform(int platformId)
        {
            var games = await dbContext.GamePlatforms.Where(gp => gp.PlatformId == platformId).Include(gp => gp.Game).Select(gp => gp.Game).ToListAsync();
            return View(games);
        }
        [HttpGet]
        public async Task<IActionResult> FilterGamesByGenres(string genre)
        {
            var games = await dbContext.Games.Where(g => $"{g.Genre}" == genre).ToListAsync();
            return View(games);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return await Task.Run(() => View());
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddGameViewModel viewModel)
        {
            Game game = new Game()
            {
                Name = viewModel.Name,
                Genre = viewModel.Genre,
                CreatedOn = viewModel.CreatedOn,
                LikeCnt = viewModel.LikeCnt,
                CreatorCompany = viewModel.CreatorCompany
            };

            await dbContext.Games.AddAsync(game);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var game = await dbContext.Games.FirstOrDefaultAsync(x => x.Id == id);
            if (game != null)
            {
                EditGameViewModel viewModel = new EditGameViewModel()
                {
                    Id = game.Id,
                    Name = game.Name,
                    Genre = game.Genre,
                    CreatedOn = game.CreatedOn,
                    LikeCnt = game.LikeCnt,
                    CreatorCompany = game.CreatorCompany,
                    Images = game.Images,
                    Platform = game.Platform
                };

                return await Task.Run(() => View("Edit",viewModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditGameViewModel viewModel)
        {
            var game = await dbContext.Games.FindAsync(viewModel.Id);
            if (game != null)
            {
                game.Name = viewModel.Name;
                game.Genre = viewModel.Genre;
                game.CreatedOn = viewModel.CreatedOn;
                game.LikeCnt = viewModel.LikeCnt;
                game.CreatorCompany = viewModel.CreatorCompany;
                game.Images = viewModel.Images;
                game.Platform = viewModel.Platform;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
