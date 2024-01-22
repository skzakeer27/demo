using admin.bal;
using admin.dal;

namespace admin
{
    public class startup
    {
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllersWithViews();
            services.AddScoped<IUserService, UserService>();


            services.AddScoped<IUserRepository, UserRepository>();





        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
        }
    }
}
