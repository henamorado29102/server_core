using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;

namespace core.Service.Interface
{
    public interface ICommentService    
    {
        Comment? GetById(int id);
        List<Comment> GetAll(int todoId);
        bool Delete(int id);
        Comment? Update(int id, Comment comment);
        Comment Save(int todoId, Comment comment);
    }
}