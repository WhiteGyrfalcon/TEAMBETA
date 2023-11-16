using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Data.Models
{
    public class GamePlatform
    {
        [ForeignKey(nameof(Game))]
        public string GameId { get; set; } = null!;

        public Game Game { get; set; } = null!;

        [ForeignKey(nameof(Platform))]
        public string PlatformId { get; set; } = null!;

        public Platform Platform { get; set; } = null!;
    }
}
