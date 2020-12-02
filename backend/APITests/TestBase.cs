using APITests.Mocks;
using Kalandear.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TFTI.Interfaces;
using TFTI.Repositories;

namespace APITests
{
    public class TestBase
    {
        /// <summary>
        ///     Base URL for the API
        /// </summary>
        private const string BASE_URL = "tfti";

        private const string SETTINGS_FILE_NAME = "appsettings.json";

        protected readonly string CreateClientUrl = $"{BASE_URL}/users";

        protected readonly string CreateEventUrl = $"{BASE_URL}/events";

        /// <summary>
        ///     The client to interact with the API
        /// </summary>
        protected readonly HttpClient Client;

        protected readonly TFTIContext StagingContext;

        private readonly MockConnection _tftiConnection;

        protected readonly IConfigurationRoot Config;

        protected TestBase()
        {
            Config = new ConfigurationBuilder()
                .AddJsonFile(SETTINGS_FILE_NAME)
                .Build();

            IWebHostBuilder builder = new WebHostBuilder()
                .UseStartup<TestStartup>()
                .UseConfiguration(Config)
                .UseEnvironment("Test");

            var server = new TestServer(builder);

            Client = server.CreateClient();

            Client.DefaultRequestHeaders.Clear();

            Client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers
                .MediaTypeWithQualityHeaderValue("application/json"));

            Client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers
                .AuthenticationHeaderValue("Bearer", "Bearer a dummy token");

            StagingContext = server.Host.Services
                .GetService(typeof(TFTIContext)) as TFTIContext;

            var connectionResolver = server.Host.Services
                .GetService(typeof(IConnectionResolver)) as IConnectionResolver;

            _tftiConnection = connectionResolver
                .Resolve(TFTIRepository.CONNECTION_NAME) as MockConnection;
        }
    }
}
