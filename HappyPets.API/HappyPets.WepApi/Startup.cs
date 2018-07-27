using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.Library;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace HappyPets.WepApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<Repository>();

            services.AddDbContext<HappyPetsDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HappyPetsDB")));

            services.AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HappyPetsAuth"),
                b => b.MigrationsAssembly("HappyPets.Data")));



            // Add-Migration <diff-migration-name> -Context IdentityDbContext


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);



            // Add-Migration HP-migration -Context IdentityDbContext
            // Update-Database -Context IdentityDbContext


            services.AddSwaggerGen(c =>
           {
               c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
           });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();


            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });


            app.UseMvc();
        }
    }
}
