namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using static Common.EntityValidationConstants.Platform;

	public class Platform
	{
		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
	}
}
