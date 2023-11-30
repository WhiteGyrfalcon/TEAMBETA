using InternetGameBlog.Services.Data.Interfaces;

namespace InternetGameBlog.Web.Extensions
{
    public static class InternetgameBlogServiceCollectionExtension
    {
        public static IServiceCollection ConfigureService(this.IServiceCollection services)
        {
            services.AddScoped<IUserService>
        }
    }
}
