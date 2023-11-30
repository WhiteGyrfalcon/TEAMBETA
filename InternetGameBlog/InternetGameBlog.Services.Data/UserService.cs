using InternetGameBlog.Data;
using InternetGameBlog.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Data
{
    public class UserService : IUserService
    {
        private GameBlogDbContext dbContext;
        public Task<bool> IsUserExistsByEmailAsync(string email)
        {
            return dbContext.Users.AnyAsync(u  => u.Email == email);
        }

        public Task<bool> IsUserExistsByPhoneNumberAsync(string number)
        {
            return dbContext.Users.AnyAsync(u => u.PhoneNumber == number);
        }
    }
}
