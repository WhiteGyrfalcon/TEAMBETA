using InternetGameBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Web.ViewModels.Platform
{
    public class EditPlatformViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GamePlatform> Games { get; set; }
    }
}
