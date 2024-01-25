namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using Microsoft.AspNetCore.Identity;

	using static Common.EntityValidationConstants.User;

	public class User : IdentityUser
	{
		public User()
		{
			this.IsActive = true;
			this.FavouriteGames = new HashSet<Game>();
			this.Comments = new HashSet<Comment>();
		}

		[Key]
		public override string Id { get; set; } = Guid.NewGuid().ToString();

		[Required]
		[MaxLength(FirstNameMaxLength)]
		public string FirstName { get; set; } = null!;

		[Required]
		[MaxLength(LastNameMaxLength)]
		public string LastName { get; set; } = null!;

		public string? ProfilePicUrl { get; set; }

		public bool IsActive { get; set; }

		public ICollection<Game> FavouriteGames { get; set; }
		public ICollection<Comment> Comments { get; set; }

	}
}