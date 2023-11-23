namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Comment
	{
		public Comment()
		{
			this.Id = Guid.NewGuid().ToString();
		}
		[Key]
		public string Id { get; set; }

		[ForeignKey(nameof(Game))]
		public string GameId { get; set; }
		public Game Game { get; set; } = null!;

		[ForeignKey(nameof(User))]
		public string UserId { get; set; } = null!;
		public User User { get; set; } = null!;

		public DateTime CreatedOn { get; set; }

		public string Content { get; set; } = null!;
	}
}
