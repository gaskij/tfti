using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kalandear.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TFTI.Interfaces;
using TFTI.Repositories;
using TFTI.API;
using System.Collections.Generic;

namespace TFTI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        ///     The swagger Json Url.
        /// </summary>
        private static string SwaggerJsonUrl => "/swagger/v1/swagger.json";

        /// <summary>
        ///     Gets the name of the application.
        /// </summary>
        private string ApplicationName => Configuration.GetValue<string>("applicationName");

        private string Version => Configuration.GetValue<string>("Version");

        private string ContactName => Configuration.GetValue<string>("ContactName");

        private string ContactEmail => Configuration.GetValue<string>("ContactEmail");

        private string Description => Configuration.GetValue<string>("Description");

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = ApplicationName,
                        Version = Version,
                        Contact = new OpenApiContact
                        {
                            Email = ContactEmail,
                            Name = ContactName,
                        },
                        Description = Description
                    });
            });

            InjectRepository(services);

            InjectConnection(services);

            InjectConnectionResolver(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseSwagger(c => {
                c.SerializeAsV2 = true;
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) => 
                    { 
                        swaggerDoc.Servers = new List<OpenApiServer> { 
                            new OpenApiServer { 
                                Url = $"{httpReq.Scheme}://{httpReq.Host.Value}"
                            } 
                        };
                    });
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(SwaggerJsonUrl, $"{ApplicationName} {Version}");
            });
        }

        /// <summary>
        ///     Inject the repositories.
        /// </summary>
        /// <param name="services"></param>
        protected virtual void InjectRepository(IServiceCollection services)
        {
            //Contract.CheckIsNotNull(nameof(services), services);

            services.AddTransient<ITFTIRepository, TFTIRepository>();
        }

        /// <summary>
        ///     Inject the database connection.
        /// </summary>
        /// <param name="services"></param>
        protected virtual void InjectConnection(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<TFTIContext>(opt => opt.UseNpgsql(ConnectionString.Get()));
        }

        protected virtual void InjectConnectionResolver(IServiceCollection services)
        {
            services.AddScoped<IConnectionResolver, ConnectionResolver>();
        }
    }
}
