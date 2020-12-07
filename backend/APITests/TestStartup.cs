using APITests.Mocks;
using Kalandear.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFTI;

namespace APITests
{
    public class TestStartup : Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public TestStartup(IConfiguration configuration): base(configuration)
        {

        }

        protected override void InjectConnection(IServiceCollection services)
        {
            services.AddSingleton(provider =>
            {
                var builder = new DbContextOptionsBuilder<TFTIContext>();

                builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

                return builder.Options;
            });

            services.AddTransient<TFTIContext>();
        }

        protected override void InjectConnectionResolver(IServiceCollection services)
        {
            services.AddScoped(r => MockConnectionResolver.Create(Configuration));
        }

    }
}
