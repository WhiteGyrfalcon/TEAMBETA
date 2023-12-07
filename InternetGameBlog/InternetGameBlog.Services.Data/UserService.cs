using InternetGameBlog.Data;
using InternetGameBlog.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Data
{
    public class UserService : IUserService
    {
        private readonly GameBlogDbContext context;
        public UserService() 
        {
            
        }

        public Task<bool> ExistsByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
