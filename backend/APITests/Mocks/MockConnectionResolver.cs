using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFTI.Interfaces;
using TFTI.Repositories;

namespace APITests.Mocks
{
    public class MockConnectionResolver : ConnectionResolver
    {
        /// <summary>
        /// 
        /// </summary>
        private static IConnectionResolver _connectionResolver; 

        /// <summary>
        ///     Lock object used to ensure that only one thread runs through
        ///     creation of <c>ConnectionResolver</c>
        /// </summary>
        private static readonly object Lock = new object();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        private MockConnectionResolver(IConfiguration configuration) : base(configuration)
        {
            Connections[TFTIRepository.CONNECTION_NAME] = new MockConnection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IConnectionResolver Create(IConfiguration configuration)
        {
            lock (Lock)
            {
                if(_connectionResolver != null)
                {
                    return _connectionResolver;
                }
                _connectionResolver = new MockConnectionResolver(configuration);
            }
            return _connectionResolver;
        }
    }
}
