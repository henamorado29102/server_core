using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using core.Service.Interface;
using core.Util;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    [ApiController]
    [Route("api/comment")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService){
            _commentService = commentService;
        }

        [HttpGet("{id}")]
         public ActionResult<ApiResponseSusses<IEnumerable<Comment>>> GetAllComments(int id)
        {
            var comments = _commentService.GetAll(id);
            var response = new ApiResponseSusses<IEnumerable<Comment>>("Comments retrieved successfully", comments);
            return Ok(response);
        }
    }
    
}