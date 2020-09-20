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
        private UserManager<User> _userManager;
        public UserProfileController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        [Route("userprofilebyId/{Id}")]
        public async Task<IActionResult> GetUserProfileById(string Id)
        {
            var result = await _userManager.FindByIdAsync(Id);
            return Ok(result);
        }
    }
}
