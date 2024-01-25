using InternetGameBlog.Data.Repository;
using InternetGameBlog.Services.Contracts;
using InternetGameBlog.Services.Data;

namespace InternetGameBlog.Web.Extensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IGameService, GameService>();
            return services;

        }
    }
}
