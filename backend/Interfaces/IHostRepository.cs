using System.Threading.Tasks;
using TFTI.Contracts;

namespace TFTI.Interfaces
{
    public interface IHostRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        Task<User> CreateUser(User host);

        /// <summary>
        ///     Retrieve a host user with the specified id.
        /// </summary>
        /// <param name="hostId">
        ///     The unique identifier of a host user.
        /// </param>
        /// <returns>
        ///     A populated <c>Host</c> object.
        /// </returns>
        Task<User> GetHost(int hostId);
    }
}
