namespace InternetGameBlog.Data
{
    using InternetGameBlog.Data.Configurations;
    using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;

	using Models;

	public class GameBlogDbContext : IdentityDbContext<User>
	{
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Platform> Platforms { get; set; }
		public DbSet<GamePlatform> GamePlatforms { get; set; }

		public GameBlogDbContext(DbContextOptions<GameBlogDbContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<GamePlatform>()
				.HasKey(key => new { key.GameId, key.PlatformId });

			builder.Entity<User>()
				.HasKey(u => u.Id);

			builder.ApplyConfiguration(new UserConfiguration());
			builder.ApplyConfiguration(new PlatformConfiguration());
			builder.ApplyConfiguration(new GameConfiguration());
			builder.ApplyConfiguration(new GamePlatformConfiguration());

			base.OnModelCreating(builder);

		}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}