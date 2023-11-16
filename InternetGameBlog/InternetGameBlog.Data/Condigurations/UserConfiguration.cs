using InternetGameBlog.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternetGameBlog.Data.Condigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(GetUsers());
        }

        public List<User> GetUsers()
        {
            var passwordHasher = new PasswordHasher<User>();
            var users = new List<User>();

            var user = new User()
            {
                Id = new Guid("605e03f7-dfb6-4fdb-9f36-481520c6b714"),
                FirstName = "Ivan",
                LastName = "Ivanov",
                Email = "ivan123@abv.bg",
                NormalizedEmail = "IVAN123@ABV.BG",
                UserName = "vankata",
                NormalizedUserName = "VANKATA",
                ProfilePicUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1700115971/schoolProjectImages/4127_zv0rup.jpg"
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "123456");
            users.Add(user);

            var user2 = new User()
            {
                Id = new Guid("16592260-d4ab-4d15-a34c-8aa894c70025"),
                FirstName = "Peter",
                LastName = "Dimitrov",
                Email = "peter@abv.bg",
                NormalizedEmail = "PETER@ABV.BG",
                UserName = "peter",
                NormalizedUserName = "PETER",
                ProfilePicUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1700116926/schoolProjectImages/5585_lafw0h.jpg"
            };
            user2.PasswordHash = passwordHasher.HashPassword(user, "357911");
            users.Add(user2);

            var user3 = new User()
            {
                Id = new Guid("111c3195-4e75-4ea9-9f4c-7c69f3fb34c6"),
                FirstName = "Georgi",
                LastName = "Petrov",
                Email = "gosho@abv.bg",
                NormalizedEmail = "GOSHO@ABV.BG",
                UserName = "gosho",
                NormalizedUserName = "GOSHO",
                ProfilePicUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1700118672/schoolProjectImages/2150771129_hrcjdi.jpg"
            };
            user3.PasswordHash = passwordHasher.HashPassword(user, "246810");
            users.Add(user3);


            return users;

        }
    }
}
