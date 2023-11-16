using InternetGameBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternetGameBlog.Data.Condigurations
{
    public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.HasData(GetPlatforms());
        }

        public List<Platform> GetPlatforms()
        {
            return new List<Platform>()
            {
                new Platform()
                {
                    Id = 1,
                    Name = "PC"
                },
                new Platform()
                {
                    Id = 2,
                    Name = "Playstation",

                },
                new Platform()
                {
                    Id = 3,
                    Name = "Xbox"
                }
            };
        }
    }
}
