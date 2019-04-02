using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoyoteNETCore.Services;
using CoyoteNETCore.DAL;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System;
using System.IO;
using CoyoteNetCore.Api;
using CoyoteNETCore.DAL.Configuration;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Coyote.NETCore
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
            services.ConfigureDataBase(Configuration);

            services.AddTransient<TestService>();

            services
                .AddMvc()
                .AddControllersAsServices()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Coyote API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Context context)
        {
            // in order to setup this project easier
            context.Database.EnsureCreated();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            
            app.UseSwagger();
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Coyote API V1");
                c.RoutePrefix = string.Empty;
                c.DocExpansion(DocExpansion.None);
            });

            //app.UseHttpsRedirection();

            app.UseMvc();
        }
    }
}
