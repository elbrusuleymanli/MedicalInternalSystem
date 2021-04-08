using MedApi.Data.Entities;
using MedApi.Infrastructures.Exceptions;
using MedApi.Resource.User;
using MedApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class AuthController : BaseController
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var user = await _userService.Login(resource.Email, resource.Password);

                var userResource = _mapper.Map<User, UserResource>(user);

                return Ok(userResource);
            }
            catch (HttpException e)
            {
                return StatusCode(e.StatusCode, e.Response);
            }
        }
       
        
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var userInput = _mapper.Map<UserRegisterResource, User>(resource);

                var user = await _userService.Register(userInput);

                var userResource = _mapper.Map<User, UserResource>(user);

                return Ok(userResource);
            }
            catch (HttpException e)
            {
                return StatusCode(e.StatusCode, e.Response);
            }
        }
    }
}
