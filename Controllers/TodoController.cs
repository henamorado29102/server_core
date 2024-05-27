using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using core.Repository.Interface;
using core.Service.Interface;
using core.Util;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        //private readonly IUserService _userService;


        public TodoController(ITodoService todoService/*, IUserService userService*/){
            _todoService = todoService;
            //_userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<ApiResponseSusses<IEnumerable<Todo>>> GetAllTodo(int id)
        {
            var todo = _todoService.GetAll(id);
            var response = new ApiResponseSusses<IEnumerable<Todo>>("Todos retrieved successfully", todo);
            return Ok(response);
        }
    }
}