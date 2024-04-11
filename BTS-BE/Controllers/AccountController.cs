using BTS_BE.Controllers.Api;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BTS_BE.Controllers
{
    [Authorize]
    public class AccountController: BaseApiController
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}
