namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using static Common.EntityValidationConstants.Platform;

	public class Platform
	{
		public Platform()
		{
			this.Games = new HashSet<GamePlatform>();
		}
		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

		public ICollection<GamePlatform> Games { get; set; }
	}
}
