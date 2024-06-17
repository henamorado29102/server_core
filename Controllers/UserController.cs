using core.Data;
using core.Dto;
using core.Filter;
using core.Models;
using core.Service.Interface;
using core.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        [ServiceFilter(typeof(SampleActionFilter))]
        [HttpGet, Authorize]
        public ActionResult<ApiResponseSusses<IEnumerable<User>>> GetAllUsers()
        {
            var users = _userService.GetAll();
            var response = new ApiResponseSusses<IEnumerable<User>>("Users retrieved successfully", users);
            return Ok(response);
        }

        [HttpPost("paginate"), Authorize]
        public async Task<ActionResult<ApiResponsePaginate<IEnumerable<User>>>> GetAllUsersPaginate(PaginateDto paginateDto)
        {
            var users = await _userService.GetAllPaginate(paginateDto.PageIndex, paginateDto.PageSize);
            var total = _userService.GetAll().Count;
            var response = new ApiResponsePaginate<IEnumerable<User>>("Users retrieved successfully", total, users);
            return Ok(response);
        }

        [HttpGet("{id}"), Authorize]
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
        [HttpPost, Authorize]
        public ActionResult<User> AddUser(UserDto user)
        {
            User u = new(user.Name, user.Lastname, user.Email);
            u = _userService.Save(u);
            return base.Ok(u);
        }

        [HttpPut, Authorize]
        public ActionResult<ApiResponseSusses<User>> UpdateUser([FromBody] UpdateUserDto user)
        {
            var u = _userService.Update(user);
            if (u == null)
            {
                var errorResponse = new ApiResponseError("User not found");
                return NotFound(errorResponse);
            }
            
            var response = new ApiResponseSusses<User>("User update successfully", u);
            return Ok(response);
        }

    }

    public class ApiResponsePaginate
    {
    }
}