using InternetGameBlog.Data.Repository;

namespace InternetGameBlog.Web.Extensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();

            return services;

        }
    }
}
