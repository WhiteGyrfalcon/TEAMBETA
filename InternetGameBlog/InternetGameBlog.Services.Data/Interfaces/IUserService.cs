using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<bool> IsUserExistsByEmailAsync(string email);
        Task<bool> IsUserExistsByPhoneNumberAsync(string number);

    }
}
