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
        
        /// <inheritdoc />
        public async Task<int> CreateEvent(NewEvent newEvent)
        {
            Event TFTIevent = new Event();
            TFTIevent.addtional_links = newEvent.addtional_links;
            TFTIevent.event_date = newEvent.event_date;
            TFTIevent.event_name = newEvent.event_name;
            TFTIevent.event_summary = newEvent.event_summary;
            TFTIevent.host_id = newEvent.host_id;
            TFTIevent.is_private = newEvent.is_private;
            TFTIevent.location = newEvent.location;

            _context.Events.Add(TFTIevent);
            await _context.SaveChangesAsync();

            return TFTIevent.event_id;
        }

        /// <inheritdoc />
        public async Task<EventAttendees> CreateEventAttendees(EventAttendees eventAttendees)
        {
            _context.EventAttendees.Add(eventAttendees);
            await _context.SaveChangesAsync();

            return eventAttendees;
        }

        public async Task<int> CreateEventInvites(NewEventInvites newEventInvites)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> CreateFriend(Friend friend)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> CreateItem(NewItem newItem)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> CreateMedia(Media media)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> CreateMessage(NewMessage newMessage)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUser(int hostId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Message> GetMessage(Message message)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
