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
        public AddGameViewModel()
        {
            this.Genres = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToHashSet();
            this.Platforms = new HashSet<PlatformViewModel>();
        }
        public string Name { get; set; } = null!;

        public Genre Genre { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatorCompany { get; set; } = null!;
        public ICollection<PlatformViewModel> Platforms { get; set; }
        public List<int> SelectedPlatformIds { get; set; } = new List<int>();
		public IEnumerable<Genre> Genres { get; set; }
    }
}
