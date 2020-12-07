using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TFTI.Interfaces
{
    public interface IConnectionResolver : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        IDbConnection Resolve(string connectionName);
    }
}
