using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("api/user/gets")]
        public IList<User> Gets()
        {
            return _userService.GetAllUser();
        }
    }
}
