using InternetGameBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Data.Configurations
{
    public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatform>
    {
        public void Configure(EntityTypeBuilder<GamePlatform> builder)
        {
            builder.HasData(GamePlatforms());
        }

        private List<GamePlatform> GamePlatforms()
        {
            return new List<GamePlatform>()
            {
                new GamePlatform()
                {
                    GameId = "523c6221-c7ec-4156-973c-ef365392be01",
                    PlatformId = 1
                },
                new GamePlatform()
                {
                    GameId = "523c6221-c7ec-4156-973c-ef365392be01",
                    PlatformId = 2
                },
                new GamePlatform()
                {
                    GameId = "523c6221-c7ec-4156-973c-ef365392be01",
                    PlatformId = 3
                },
            };

        }
    }
}
