using InternetGameBlog.Web.ViewModels.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Contracts
{
    public interface IGameService
    {
        Task<List<GameViewModel>> GetAllGamesAsync();
    }
}
