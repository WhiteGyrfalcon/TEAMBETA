namespace InternetGameBlog.Data.Models
{
	public class User
	{
        public User()
        {
            this.FavouriteGames = new HashSet<Game>();
            this.Comments = new HashSet<Comment>();
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string ProfilePicUrl { get; set; } = null!;

        ICollection<Game> FavouriteGames { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}