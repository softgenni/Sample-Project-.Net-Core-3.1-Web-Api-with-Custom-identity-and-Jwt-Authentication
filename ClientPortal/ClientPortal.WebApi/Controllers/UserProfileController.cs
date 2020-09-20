using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientPortal.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClientPortal.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private Services.IUserManager UserManager;
        public UserProfileController(Services.IUserManager userManager)
        {
            UserManager = userManager;
        }
        [HttpGet]
        [Route("userprofilebyId/{Id}")]
        public async Task<IActionResult> GetUserProfileById(string Id)
        {
            var result = await UserManager.GetUserByIdAsync(Id);
            return Ok(result);
        }
    }
}
