namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Comment
	{
		[Key]
		public Guid Id { get; set; }

		[ForeignKey(nameof(Game))]
		public Guid GameId { get; set; }
		public Game Game { get; set; } = null!;

		[ForeignKey(nameof(User))]
		public Guid UserId { get; set; }
		public User User { get; set; } = null!;

		public DateTime CreatedOn { get; set; }

		public string Content { get; set; } = null!;
	}
}
