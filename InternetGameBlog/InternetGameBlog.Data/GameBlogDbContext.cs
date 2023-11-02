namespace InternetGameBlog.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class GameBlogDbContext : IdentityDbContext
    {
        public GameBlogDbContext(DbContextOptions<GameBlogDbContext> options)
            : base(options)
        {
        }
    }
}