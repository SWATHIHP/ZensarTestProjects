using Castle.Core.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductStoreApi.Models;
using ProductStoreApi.Models.Repositories;

namespace ProductStoreApi
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddControllers();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
