using InternetGameBlog.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Web.ViewModels.Game
{
    public class AddGameViewModel
    {
        public string Name { get; set; } = null!;

        public Genre Genre { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LikeCnt { get; set; }

        public string CreatorCompany { get; set; } = null!;
    }
}
