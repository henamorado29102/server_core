using core.Data;
using core.Dto;
using core.Models;
using core.Service.Interface;
using core.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace core.controller
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult<ApiResponseSusses<IEnumerable<User>>> GetAllUsers()
        {
            var users = _userService.GetAll();
            var response = new ApiResponseSusses<IEnumerable<User>>("Users retrieved successfully", users);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<ApiResponseSusses<User>> GetUser(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                var errorResponse = new ApiResponseError("User not found");
                return NotFound(errorResponse);
            }

            var response = new ApiResponseSusses<User>("User retrieved successfully", user);
            return Ok(response);


        }
        [HttpPost]
        public ActionResult<User> AddUser(UserDto user)
        {
            User u = new(user.Name, user.Lastname, user.Email);
            u = _userService.Save(u);
            return base.Ok(u);
        }

        [HttpPut("{id}")]
        public ActionResult<ApiResponseSusses<User>> UpdateUser(int id, [FromBody] UserDto user)
        {
            var u = _userService.Update(id, user);
            if (u == null)
            {
                var errorResponse = new ApiResponseError("User not found");
                return NotFound(errorResponse);
            }
            
            var response = new ApiResponseSusses<User>("User update successfully", u);
            return Ok(response);
        }

    }
}