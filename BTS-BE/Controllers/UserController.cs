using BTS.Core.Interfaces;
using BTS_BE.Controllers.Api;
using Microsoft.AspNetCore.Mvc;

namespace BTS_BE.Controllers
{
    public class UserController: BaseApiController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get user information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _userRepository.GetUser(id);
            return Ok(result);
        }
    }
}
