using InternetGameBlog.Data.Models;
using InternetGameBlog.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Web.ViewModels.Game
{
    public class EditGameViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; } = null!;

        public Genre Genre { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LikeCnt { get; set; }

        public string CreatorCompany { get; set; } = null!;

        public ICollection<GamePlatform> Platform { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
