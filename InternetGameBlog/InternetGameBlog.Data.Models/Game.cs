namespace InternetGameBlog.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using Enum;

	public class Game
	{
        public Game()
        {
            this.Platform = new HashSet<string>();
        }

        [Key]
		public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public Genre Genre { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LikeCnt { get; set; }

        public string CreatorCompany { get; set; } = null!;

        public ICollection<string> Platform { get; set; }
    }
}
