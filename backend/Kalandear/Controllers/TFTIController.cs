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

        [Route("events")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<int> CreateEvent(Event eventDetails)
        {
            int eventId = _HostRepository.CreateEvent(eventDetails).Result;

            return eventId;
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
