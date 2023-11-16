namespace InternetGameBlog.Data
{
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;

	using Models;

	public class GameBlogDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
	{
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Platform> Platforms { get; set; }

		public GameBlogDbContext(DbContextOptions<GameBlogDbContext> options)
			: base(options)
		{
		}
	}
}