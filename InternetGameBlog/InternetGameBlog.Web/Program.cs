namespace InternetGameBlog.Web
{
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;

	using InternetGameBlog.Data;
	using InternetGameBlog.Data.Models;
    using System.Security.Principal;
    using CloudinaryDotNet;
    using InternetGameBlog.Web.Extensions;

    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services.AddDbContext<GameBlogDbContext>(options =>
				options.UseSqlServer(connectionString));

			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddDefaultIdentity<User>(options =>
				{
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 5;
                })
				.AddRoles<IdentityRole>()
				.AddEntityFrameworkStores<GameBlogDbContext>();

			builder.Services.AddControllersWithViews();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";


            });

            builder.Services.ConfigureServices();


            ConfigureCloudinaryService(builder.Services, builder.Configuration);

			var app = builder.Build();

			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");
			app.MapRazorPages();

			app.Run();
		}
		private static void ConfigureCloudinaryService(IServiceCollection services, IConfiguration configuration)
		{

			var cloudName = configuration.GetValue<string>("AccountSettings:CloudName");
			var apiKey = configuration.GetValue<string>("AccountSettings:ApiKey");
			var apiSecret = configuration.GetValue<string>("AccountSettings:ApiSecret");

			if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
			{
				throw new ArgumentException("Please specify your Cloudinary account Information");
			}

			services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
		}
	}
}