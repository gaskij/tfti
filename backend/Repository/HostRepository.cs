using Kalandear.Data;
using System.Threading.Tasks;
using TFTI.Contracts;
using TFTI.Interfaces;

namespace TFTI.Repositories
{
    public class HostRepository : IHostRepository
    {
        private TFTIContext _context;

        #region Constructor
        /// <summary>
        ///     Constructor to set the Kalandear database context.
        /// </summary>
        /// <param name="context"></param>
        public HostRepository(TFTIContext context)
        {
            _context = context;
        }
        #endregion

        #region Public Methods
        /// <inheritdoc/>
        public async Task<User> CreateUser(User newUser)
        {
            User user = new User();
            user.Name = newUser.Name;

            _context.Hosts.Add(user);
            //_context.SaveChanges();

            return user;
        }

        /// <inheritdoc/>
        public async Task<User> GetHost(int hostId)
        {
            User hostResponse = new User();

            // use Entity framework core to get host by id
            hostResponse = await _context.Hosts.FindAsync(hostId);

            return hostResponse;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
