﻿using InternetGameBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InternetGameBlog.Web.ViewModels.Game;
using InternetGameBlog.Data.Models;
using InternetGameBlog.Data.Models.Enum;
using InternetGameBlog.Web.ViewModels;
using Microsoft.AspNetCore.Cors.Infrastructure;
using InternetGameBlog.Services.Contracts;

namespace InternetGameBlog.Web.Controllers
{
	public class GameController : Controller
	{
		private readonly GameBlogDbContext dbContext;
		private readonly IGameService gameService;
		public GameController(GameBlogDbContext _context, IGameService gameService)
		{
			this.dbContext = _context;
			this.gameService = gameService;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var games = await dbContext.Games.ToListAsync();
			return View(games);
		}
		[HttpGet]
		public async Task<IActionResult> SortGamesByLikeCnt()
		{
			var games = await dbContext.Games.OrderByDescending(g => g.LikeCnt).ToListAsync();
			return View(games);
		}
		[HttpGet]
		public async Task<IActionResult> FilterGamesByCreator(string creatorCompany)
		{
			var games = await dbContext.Games.Where(g => g.CreatorCompany == creatorCompany).ToListAsync();
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
		public async Task<IActionResult> SelectGame(string id)
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

				return await Task.Run(() => View("Select", viewModel));
			}
			return RedirectToAction("Index");
		}
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var model = new AddGameViewModel()
			{
				Platforms = await this.dbContext.Platforms
					.Select(p => new PlatformViewModel()
					{
						Id = p.Id,
						Name = p.Name,
					})
					.ToListAsync(),
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddGameViewModel viewModel)
		{
			try
			{
				if (!IsValidEnumValue(viewModel.Genre))
				{
					ModelState.AddModelError(nameof(Genre), "Invalid Genre Type.");
				}

				if (await this.dbContext.Games.AnyAsync(g => g.Name == viewModel.Name))
				{
					ModelState.AddModelError(string.Empty, "Game with this name exists!");
				}

				if (!ModelState.IsValid)
				{
					return this.View(viewModel);
				}

				Game game = new Game()
				{
					Name = viewModel.Name,
					Genre = viewModel.Genre,
					CreatedOn = viewModel.CreatedOn,
					LikeCnt = 0,
					CreatorCompany = viewModel.CreatorCompany,
				};

				foreach (var platformId in viewModel.SelectedPlatformIds)
				{
					GamePlatform gamePlatform = new GamePlatform()
					{
						GameId = game.Id,
						PlatformId = platformId
					};
				}


				await dbContext.Games.AddAsync(game);
				await dbContext.SaveChangesAsync();

				return RedirectToAction("Index","Home");
				//return RedirectToAction("Detail", "Game", new { id = game.Id });
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty,
					"Unexpected error occurred while trying to add your new car!");

				return View(viewModel);
			}

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

				return await Task.Run(() => View("Edit", viewModel));
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

		private bool IsValidEnumValue<TEnum>(TEnum value)
		{
			return Enum.IsDefined(typeof(TEnum), value);
		}

		public async Task<IActionResult> AllGames()
		{
			var games = await gameService.GetAllGamesAsync();

			return View("All", games);
		}
	}
}
