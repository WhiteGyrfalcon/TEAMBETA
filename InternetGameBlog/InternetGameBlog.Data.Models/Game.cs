namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using Enum;

	using static Common.EntityValidationConstants.Game;

	public class Game
	{
		public Game()
		{
			this.Platform = new HashSet<Platform>();
			this.Images = new HashSet<Image>();
			this.Comments = new HashSet<Comment>();
		}

		[Key]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		public Genre Genre { get; set; }

		public DateTime CreatedOn { get; set; }

		public int LikeCnt { get; set; }

		[Required]
		[MaxLength(CreatorCompanyMaxLength)]
		public string CreatorCompany { get; set; } = null!;

		public ICollection<Platform> Platform { get; set; }
		public ICollection<Image> Images { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
