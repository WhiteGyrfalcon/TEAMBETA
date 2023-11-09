namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Image
	{
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Game))]
        public Guid GameId { get; set; }
        public Game Game { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
	}
}
