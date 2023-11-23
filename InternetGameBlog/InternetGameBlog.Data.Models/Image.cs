namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Image
	{
		public Image()
		{
			this.Id = Guid.NewGuid().ToString();
		}

        [Key]
        public string Id { get; set; }

		[ForeignKey(nameof(Game))]
		public string GameId { get; set; } = null!;
        public Game Game { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
	}
}
