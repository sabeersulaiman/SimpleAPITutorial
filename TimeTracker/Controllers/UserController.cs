using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models;
using TimeTracker.Services;

namespace TimeTracker.Controllers
{
    [Route("api/User")]
    public class UserController: Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<Response<User>> Register([FromBody] User user)
        {
            if(user == null)
            {
                return Response<User>.CreateResponse(false, "Please provide valid user data.", null);
            }

            try
            {
                var newUser = await _userService.RegisterUser(user);

                return Response<User>.CreateResponse(true, "Successfully registered.", newUser);
            }
            catch(Exception e)
            {
                return Response<User>.CreateResponse(false, e.Message, null);
            }
        }
    }
}
