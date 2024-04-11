using BTS_BE.Controllers.Api;
using Microsoft.AspNetCore.Mvc;

namespace BTS_BE.Controllers
{
    public class UserController: BaseApiController
    {
        /// <summary>
        /// Get user information
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string userName)
        {
            return Ok(userName);
        }
    }
}
