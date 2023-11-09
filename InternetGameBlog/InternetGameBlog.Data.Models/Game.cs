namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using Enum;

	public class Game
	{
		public Game()
		{
			this.Platform = new HashSet<string>();
			this.Images = new HashSet<Image>();
			this.Comments = new HashSet<Comment>();
		}

		[Key]
		public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public Genre Genre { get; set; }

		public DateTime CreatedOn { get; set; }

		public int LikeCnt { get; set; }

		public string CreatorCompany { get; set; } = null!;

		public ICollection<string> Platform { get; set; }
		public ICollection<Image> Images { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
