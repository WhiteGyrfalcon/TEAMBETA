using InternetGameBlog.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Web.ViewModels.Game
{
    public class GameViewModel
    {
        public GameViewModel()
        {
            this.Platforms = new HashSet<string>();
        }

        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public int LikeCnt { get; set; }

        public string CreatorCompany { get; set; } = null!;

        public ICollection<string> Platforms { get; set; }

    }
}
