using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Contracts
{
    public interface IUserService
    {
        Task<bool> ExistsByEmailAsync(string email);
    }
}
