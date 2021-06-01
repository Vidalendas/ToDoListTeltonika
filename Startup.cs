using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TODO_list.Data;
using ToDoListTeltonika.Data;

namespace ToDoListTeltonika
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



     
        public void ConfigureServices(IServiceCollection services)
        {
            string MySqlConncectionStr = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ToDoContext>(opt => opt.UseMySql(MySqlConncectionStr, ServerVersion.AutoDetect(MySqlConncectionStr)));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IToDoListRepo, SqlToDoListRepo>();

            services.AddControllers();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
