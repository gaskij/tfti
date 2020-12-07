using System.Threading.Tasks;
using TFTI.Contracts;

namespace TFTI.Interfaces
{
    public interface ITFTIRepository
    {
        #region Create Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        Task<int> CreateUser(NewUser newuser);

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
        Task<EventAttendees> CreateEventAttendees(NewEventAttendee newEventAttendees);

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
        #endregion

        #region Update Methods
        /// <summary>
        ///     Update an existing user.
        /// </summary>
        /// <param name="user">
        ///     The user oject to be updated.
        /// </param>
        /// <returns>
        ///     A populated user object
        /// </returns>
        public Task<User> UpdateUser(User user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventDetails"></param>
        /// <returns></returns>
        Task<Event> UpdateEvent(Event eventDetails);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventAttendees"></param>
        /// <returns></returns>
        Task<EventAttendees> UpdateEventAttendees(EventAttendees eventAttendees);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventInvites"></param>
        /// <returns></returns>
        Task<EventInvites> UpdateEventInvites(EventInvites EventInvites);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="friend"></param>
        /// <returns></returns>
        Task<Friend> UpdateFriend(Friend friend);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<Item> UpdateItem(Item item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        Task<Media> UpdateMedia(Media media);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<Message> UpdateMessage(Message message);

        #endregion

        #region Get Methods
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
        /// <param name="eventId"></param>
        /// <returns></returns>
        Task<Event> GetEvent(int eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventDetailsId"></param>
        /// <returns></returns>
        Task<CompleteEvent> GetCompleteEvent(int eventDetailsId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventAttendees"></param>
        /// <returns></returns>
        Task<EventAttendees> GetEventAttendees(int eventAttendeesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventInvites"></param>
        /// <returns></returns>
        Task<EventInvites> GetEventInvites(int eventInvitesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="friend"></param>
        /// <returns></returns>
        Task<Friend> GetFriend(int friendId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<Item> GetItem(int itemId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        Task<Media> GetMedia(int mediaId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<Message> GetMessage(int messageId);
        #endregion
    }
}
