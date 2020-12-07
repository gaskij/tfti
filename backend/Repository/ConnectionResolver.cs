using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TFTI.Interfaces;

namespace TFTI.Repositories
{
    public class ConnectionResolver : IConnectionResolver
    {
        protected readonly IDictionary<string, IDbConnection> Connections = new Dictionary<string, IDbConnection>();

        /// <summary>
        ///     Initializes a new instance of the <see cref="ConnectionResolver"/> class.
        /// </summary>
        /// <param name="configuration">
        ///     The configuration.
        /// </param>
        public ConnectionResolver(IConfiguration configuration)
        {
            IConfigurationSection section = configuration.GetSection("ConnectionStrings");

            var children = section.GetChildren();

            foreach (IConfigurationSection child in children)
            {
                Connections.Add(child.Key, new NpgsqlConnection ( child.Value));
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            foreach(string connectionString in Connections.Keys)
            {
                Connections[connectionString].Dispose();
            }
        }

        /// <inheritdoc />
        public IDbConnection Resolve(string connectionName)
        {
            IDbConnection matchingConnection = Connections[connectionName];

            return matchingConnection;
        }
    }
}
