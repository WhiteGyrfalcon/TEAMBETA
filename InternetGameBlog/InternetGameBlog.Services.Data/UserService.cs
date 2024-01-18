using InternetGameBlog.Data;
using InternetGameBlog.Data.Models;
using InternetGameBlog.Data.Repository;
using InternetGameBlog.Services.Contracts;
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
        private readonly IRepository repo;
        public UserService(IRepository repo) 
        {
            this.repo = repo;
        }

        public Task Create(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsByEmailAsync(string email)
        {
            bool isExists = await repo.All<User>()
                .AnyAsync(u => u.Email == email);

            return isExists;
        }

        public async Task<bool> ExistsByPhoneAsync(string phoneNumber)
        {
            bool isExists = await repo.All<User>()
                .AnyAsync(u => u.PhoneNumber == phoneNumber);

            return isExists;
        }
    }
}
