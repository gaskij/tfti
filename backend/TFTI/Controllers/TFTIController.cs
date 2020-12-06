using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TFTI.Contracts;
using TFTI.Interfaces;

namespace Kalandear.API.Controllers
{
    [Route("V1/tfti")]
    [ApiController]
    public class TFTIController : ControllerBase
    {
        private readonly IHostRepository _HostRepository;
        public TFTIController(IHostRepository hostRepository)
        {
            _HostRepository = hostRepository;
        }

        /// <summary>
        ///     Create a new host and publish it to the database.
        /// </summary>
        /// <param name="host">
        ///     The host to be created
        /// </param>
        /// <returns>
        /// </returns>
        [Route("user")]
        [HttpPost]
        public async Task<int> CreateUser([FromBody] NewUser user)
        {
            int userResponse = _HostRepository.CreateUser(user).Result;

            return userResponse;
        }

        //[Route("event")]
        //[HttpPost]
        //public async Task MakeEvent(Event eventDetails)
        //{
        //    _HostRepository.MakeEvent();
        //}



        
        /// <summary>
        ///     Create a new invite and publish it to the database.
        /// </summary>
        /// <param name="eventInvite">
        ///    New event invite to be created
        /// </param>
        /// <returns>
        /// </returns>

        [Route("events/invites")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateEventInvites([FromBody] NewEventInvites newEventInvites)
        {
            int eventId = _HostRepository.CreateEventInvites(newEventInvites).Result;

            return eventId;
        }



        /// <summary>
        ///     Create a new item and publish it to the database.
        /// </summary>
        /// <param name="newItem">
        ///    New item invite to be created
        /// </param>
        /// <returns>
        /// </returns>
        [Route("items")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateItem([FromBody] NewItem newItem )
        {
            int itemId = _HostRepository.CreateItem(newItem).Result;

            return itemId;
        }


        /// <summary>
        ///     Retrieve a host user based on the specified id.
        /// </summary>
        /// <param name="hostId"></param>
        /// <returns></returns>
        //[Route("host/{hostId}")]
        //[HttpGet]
        //public async Task<User> GetHost(int hostId)
        //{
        //    // TODO: Check that the host id is valid

        //    User response;

        //    response = _HostRepository.GetHost(hostId).Result;

        //    return response;
        //}
    }
}
