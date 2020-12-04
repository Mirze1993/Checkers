using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkers.DB;
using Checkers.Oyun;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Checkers.extensionMetods;
using Microsoft.OpenApi.Models;

namespace Checkers
{
    public class Startup
    {
        public IConfiguration Config { get; }

        public Startup(IConfiguration config)
        {
            Config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(x =>
            x.IdleTimeout = TimeSpan.FromMinutes(10));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSwaggerGen(s=>s.SwaggerDoc("v1",new OpenApiInfo {Title = "My API", Version = "v1" }));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddDbContextPool<AppContex>(options =>
            options.UseSqlServer(Config.GetConnectionString("BloggingDatabase")));


            services.AddScoped<IRepostory, Repostory>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseSession();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc(r =>
            {
                r.MapRoute("default", "{Controller=Game}/{Action=Index}/{id?}");
            });
            
        }


    }
}
