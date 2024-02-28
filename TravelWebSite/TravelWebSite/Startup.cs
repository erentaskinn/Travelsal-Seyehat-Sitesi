using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Travel_BussinessLayer.Container;
using Travel_DataAccessLayer.Concerate;
using Travels_EntityLayer.Concrete;
using TravelWebSite.CQRS.Handlers.DestinationHandlers;
using TravelWebSite.Models;

namespace TravelWebSite
{
    public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			configuration = configuration;
		}
		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<GetAllDestinationQueryHandler>();
			services.AddScoped<GetDestinationByIdQueryHandler>();
			services.AddScoped<CreateDestinationCommandHandler>();
			services.AddScoped<RemoveDestinationCommandHandler>();
			services.AddScoped<UpdateDestinationCommandHandler>();
			services.AddMediatR(typeof(Startup));

			services.AddLogging(x =>
			{
				x.ClearProviders();
				x.SetMinimumLevel(LogLevel.Debug);
				x.AddDebug();
			});

			services.AddDbContext<Context>();
			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

			services.AddHttpClient();

			services.ContainerDependencies();
			services.AddAutoMapper(typeof(Startup));
			services.CustomerValidator();

            services.AddControllersWithViews().AddFluentValidation();

            services.AddControllersWithViews();

			services.AddMvc(config =>
			{
				var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
				config.Filters.Add(new AuthorizeFilter(policy));
			});
			services.AddMvc();
			services.ConfigureApplicationCookie(options =>
			{
				options.LogoutPath = "/Login/SingIn/";
			});
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
		{
			var path=Directory.GetCurrentDirectory();
			loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Eror");
				app.UseHsts();
			}
			app.UseStatusCodePagesWithReExecute("/ErorPage/Eror404","?code={0}");

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseAuthentication();	
			app.UseRouting();

			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{Id?}"
					);
			});
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapControllerRoute(
			//	  name: "areas",
			//	  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
			//	);
			//});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

        }
    }
}
