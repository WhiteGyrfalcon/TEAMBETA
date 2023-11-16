using InternetGameBlog.Data.Models;
using InternetGameBlog.Data.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Data.Condigurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            throw new NotImplementedException();
        }
        public List<Game> GetGames()
        {
            var games = new List<Game>();

            var game = new Game()
            {
                Id = new Guid("523c6221-c7ec-4156-973c-ef365392be01"), 
                CreatorCompany = "GameCreating", 
                Name = "Minecraft", 
                Genre = Genre.Adventure,
                CreatedOn = DateTime.Now,
                LikeCnt = 20, 


            };
            games.Add(game);

            return games;
        }
    }
}
