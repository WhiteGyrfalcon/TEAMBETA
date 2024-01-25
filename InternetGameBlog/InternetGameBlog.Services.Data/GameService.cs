using InternetGameBlog.Data.Models;
using InternetGameBlog.Data.Repository;
using InternetGameBlog.Services.Contracts;
using InternetGameBlog.Web.ViewModels.Game;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Data
{
    public class GameService : IGameService
    {
        private readonly IRepository repo;
        public GameService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<List<GameViewModel>> GetAllGamesAsync()
        {
            var games = await repo.All<Game>()
                .Include(g => g.Platform)
                .Select(g => new GameViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    LikeCnt = g.LikeCnt,
                    Genre = g.Genre.ToString(),
                    CreatedOn = g.CreatedOn.ToString("dddd, dd MMMM yyyy"),
                    CreatorCompany = g.CreatorCompany,
                    Platforms = g.Platform.Select(p => p.Platform.Name).ToList(),

                })
                .ToListAsync();

            return games;
        }
    }
}
