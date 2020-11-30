using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TFTI.Contracts;
using TFTI.Interfaces;

namespace Kalandear.API.Controllers
{
    [Route("tfti/")]
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
        [Route("host")]
        [HttpPost]
        public async Task<int> CreateHost([FromBody] NewUser user)
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
