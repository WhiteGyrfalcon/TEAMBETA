namespace InternetGameBlog.Data.Models
{
	public class User
	{
        public User()
        {
            this.Games = new HashSet<Game>();
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string ProfilePicUrl { get; set; } = null!;

        ICollection<Game> Games { get; set; }
	}
}