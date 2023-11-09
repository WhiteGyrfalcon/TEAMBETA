using System.ComponentModel.DataAnnotations;

namespace InternetGameBlog.Data.Models
{
	public class User
	{
        public User()
        {
            Id = Guid.NewGuid();
            this.FavouriteGames = new HashSet<Game>();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string ProfilePicUrl { get; set; } = null!;

        ICollection<Game> FavouriteGames { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}