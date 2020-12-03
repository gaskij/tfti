using System.Threading.Tasks;
using TFTI.Contracts;

namespace TFTI.Interfaces
{
    public interface ITFTIRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        Task<int> CreateUser(NewUser newuser);

        /// <summary>
        ///     Retrieve a host user with the specified id.
        /// </summary>
        /// <param name="hostId">
        ///     The unique identifier of a host user.
        /// </param>
        /// <returns>
        ///     A populated <c>Host</c> object.
        /// </returns>
        Task<User> GetUser(int hostId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventDetails"></param>
        /// <returns></returns>
        Task<int> CreateEvent(NewEvent newEvent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventAttendees"></param>
        /// <returns></returns>
        Task<EventAttendees> CreateEventAttendees(EventAttendees eventAttendees);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventInvites"></param>
        /// <returns></returns>
        Task<int> CreateEventInvites(NewEventInvites newEventInvites);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="friend"></param>
        /// <returns></returns>
        Task<int> CreateFriend(Friend friend);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<int> CreateItem(NewItem newItem);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        Task<int> CreateMedia(Media media);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<int> CreateMessage(NewMessage message);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<Message> GetMessage(Message message);
    }
}
