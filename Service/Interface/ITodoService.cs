using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;

namespace core.Service.Interface
{
    public interface ITodoService
    {
        Todo? GetById(int id);
        List<Todo> GetAll(int userId);
        bool Delete(int id);
        Todo? Update(int id, Todo todo);
        Todo Save(int userId, Todo todo);
    }
}