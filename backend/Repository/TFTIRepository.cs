using Kalandear.Data;
using System.Threading.Tasks;
using TFTI.Contracts;
using TFTI.Interfaces;

namespace TFTI.Repositories
{
    public class TFTIRepository : ITFTIRepository
    {
        public const string CONNECTION_NAME = "TFTIConnection";

        private TFTIContext _context;

        #region Constructor
        /// <summary>
        ///     Constructor to set the Kalandear database context.
        /// </summary>
        /// <param name="context"></param>
        public TFTIRepository(TFTIContext context)
        {
            _context = context;
        }
        #endregion

        #region Public Methods
        /// <inheritdoc/>
        public async Task<int> CreateUser(NewUser newUser)
        {
            User user = new User();
            user.first_name = newUser.first_name;
            user.last_name = newUser.last_name;
            user.email = newUser.email;
            user.pass_hash = newUser.pass_hash;
            user.salt = newUser.salt;
            user.phone_number = newUser.phone_number;
            user.user_summary = newUser.user_summary;


            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.id;
        }

        /// <inheritdoc/>
        public async Task<User> GetHost(int hostId)
        {
            User hostResponse = new User();

            // use Entity framework core to get host by id
            hostResponse = await _context.Users.FindAsync(hostId);

            return hostResponse;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
