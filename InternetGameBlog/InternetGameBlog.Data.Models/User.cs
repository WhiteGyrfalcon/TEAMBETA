namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using Microsoft.AspNetCore.Identity;

	using static Common.EntityValidationConstants.User;

	public class User : IdentityUser<Guid>
	{
		public User()
		{
			Id = Guid.NewGuid();
			this.FavouriteGames = new HashSet<Game>();
			this.Comments = new HashSet<Comment>();
		}

		[Key]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(FirstNameMaxLength)]
		public string FirstName { get; set; } = null!;

		[Required]
		[MaxLength(LastNameMaxLength)]
		public string LastName { get; set; } = null!;

		public string ProfilePicUrl { get; set; } = null!;

		public ICollection<Game> FavouriteGames { get; set; }
		public ICollection<Comment> Comments { get; set; }

	}
}