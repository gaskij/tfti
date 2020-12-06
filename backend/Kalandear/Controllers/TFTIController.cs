using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TFTI.Contracts;
using TFTI.Interfaces;

namespace Kalandear.API.Controllers
{
    [Route("tfti")]
    [ApiController]
    public class TFTIController : ControllerBase
    {
        private readonly ITFTIRepository _HostRepository;
        public TFTIController(ITFTIRepository hostRepository)
        {
            _HostRepository = hostRepository;
        }

        #region Post Endpoints
        /// <summary>
        ///     Create a new host and publish it to the database.
        /// </summary>
        /// <param name="host">
        ///     The host to be created
        /// </param>
        /// <returns>
        /// </returns>
        [Route("users")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateUser([FromBody] NewUser newUser)
        {
            int userResponse = _HostRepository.CreateUser(newUser).Result;

            return userResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventDetails">
        ///     The new event to be created.
        ///     "event" is keyword so we must use eventDetails.
        /// </param>
        /// <returns></returns>
        [Route("events")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateEvent([FromBody] NewEvent eventDetails)
        {
            int eventId = _HostRepository.CreateEvent(eventDetails).Result;

            return eventId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventAttendees"></param>
        /// <returns></returns>
        [Route("event-attendees")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<EventAttendees> CreateEventAttendees([FromBody] EventAttendees eventAttendees)
        {
            var eventAttendeeResults = _HostRepository.CreateEventAttendees(eventAttendees).Result;

            return eventAttendeeResults;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="friend"></param>
        /// <returns></returns>
        [Route("friends")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateFriend([FromBody] Friend friend)
        {
            var result = _HostRepository.CreateFriend(friend).Result;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [Route("items")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateItems([FromBody] NewItem item)
        {
            var result = _HostRepository.CreateItem(item).Result;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        [Route("media")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateMedia([FromBody] Media media)
        {
            var result = _HostRepository.CreateMedia(media).Result;

            return result;
        }

        [Route("messages")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateMessage([FromBody] NewMessage message)
        {
            var result = _HostRepository.CreateMessage(message).Result;

            return result;
        }
        #endregion

        #region Put Endpoints
        [Route("users")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<User> UpdateUser([FromBody] User user)
        {
            User result = _HostRepository.UpdateUser(user).Result;

            return result;
        }

        [Route("events")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Event> UpdateEvent([FromBody] Event eventDetails)
        {
            var result = _HostRepository.UpdateEvent(eventDetails).Result;

            return result;
        }

        [Route("event-attendees")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<EventAttendees> UpdateEventAttendees([FromBody] EventAttendees eventAttendees)
        {
            var eventAttendeeResults = _HostRepository.UpdateEventAttendees(eventAttendees).Result;

            return eventAttendeeResults;
        }

        [Route("friends")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Friend> UpdateFriend([FromBody] Friend friend)
        {
            var result = _HostRepository.UpdateFriend(friend).Result;

            return result;
        }

        [Route("items")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Item> UpdateItems([FromBody] Item item)
        {
            var result = _HostRepository.UpdateItem(item).Result;

            return result;
        }

        [Route("media")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Media> UpdateMedia([FromBody] Media media)
        {
            var result = _HostRepository.UpdateMedia(media).Result;

            return result;
        }

        [Route("messages")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Message> UpdateMessage([FromBody] Message message)
        {
            var result = _HostRepository.UpdateMessage(message).Result;

            return result;
        }
        #endregion

        #region Get Endpoints
        [Route("users/{userId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<User> GetUser(int userId)
        {
            User result = _HostRepository.GetUser(userId).Result;

            return result;
        }

        [Route("events/{eventDetailsId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Event> GetEvent(int eventDetailsId)
        {
            var result = _HostRepository.GetEvent(eventDetailsId).Result;

            return result;
        }

        [Route("event-attendees/{eventAttendeesId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<EventAttendees> GetEventAttendees(int eventAttendeesId)
        {
            var eventAttendeeResults = _HostRepository.GetEventAttendees(eventAttendeesId).Result;

            return eventAttendeeResults;
        }

        [Route("event-attendees/{eventInvitesId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<EventInvites> GetEventInvites(int eventAttendeesId)
        {
            var results = _HostRepository.GetEventInvites(eventAttendeesId).Result;

            return results;
        }

        [Route("friends/{friendId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Friend> GetFriend(int friendId)
        {
            var result = _HostRepository.GetFriend(friendId).Result;

            return result;
        }

        [Route("items/{itemId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Item> GetItems(int itemId)
        {
            var result = _HostRepository.GetItem(itemId).Result;

            return result;
        }

        [Route("media/{mediaId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Media> GetMedia(int mediaId)
        {
            var result = _HostRepository.GetMedia(mediaId).Result;

            return result;
        }

        [Route("messages/{messageId}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Message> GetMessage(int messageId)
        {
            var result = _HostRepository.GetMessage(messageId).Result;

            return result;
        }
        #endregion
    }
}
