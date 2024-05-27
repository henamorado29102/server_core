using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using core.Repository.Interface;
using core.Service.Interface;

namespace core.Service
{
    public class TodoService:ITodoService
    {
        private readonly IRepository<Todo> _todoRepository;
        private readonly IRepository<User> _userRepository;

        public TodoService(IRepository<Todo> todoRepository, IRepository<User> userRepository){
            _todoRepository = todoRepository;
            _userRepository = userRepository;
        }
        public bool Delete(int id)
        {
            Todo? todo= _todoRepository.GetById(id);
            if(todo==null){
                return false;
            }
            return _todoRepository.Delete(todo);
        }

        public List<Todo> GetAll(int userId)
        {
            return _todoRepository.GetAll().Where(t => t.UserId == userId).ToList();
        }

        public Todo? GetById(int id)
        {
            return _todoRepository.GetById(id);
        }

        public Todo Save(int userId, Todo todo)
        {
            User? u = _userRepository.GetById(userId);
            if(u==null){
                throw new Exception("User not exist");
            }
            todo.UserId = userId;
            return _todoRepository.Save(todo);            
        }

        public Todo? Update(int id, Todo todo)
        {
            Todo? t = _todoRepository.GetById(id) ?? throw new Exception("Todo not exist");
            t.Description = todo.Description;            
            t.Title = todo.Title;            
            return _todoRepository.Update(t);
            
        }
    }
}