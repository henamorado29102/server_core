using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using core.Repository.Interface;
using core.Service.Interface;

namespace core.Service
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commetRepository;
        private readonly IRepository<Todo> _todoRepository;

        public CommentService(IRepository<Comment> commentRepository, IRepository<Todo> todoRepository){
            _commetRepository = commentRepository;
            _todoRepository = todoRepository;
        }
        public bool Delete(int id)
        {
            Comment? comment= _commetRepository.GetById(id);
            if(comment==null){
                return false;
            }
            return _commetRepository.Delete(comment);
        }

        public List<Comment> GetAll(int todoId)
        {
            return _commetRepository.GetAll().Where(c => c.TodoId == todoId).ToList();
        }

        public Comment? GetById(int id)
        {
            return _commetRepository.GetById(id);
        }

        public Comment Save(int todoId, Comment comment)
        {
            Todo? u = _todoRepository.GetById(todoId);
            if(u==null){
                throw new Exception("Todo not exist");
            }
            comment.TodoId = todoId;
            return _commetRepository.Save(comment);            
        }

        public Comment? Update(int id, Comment comment)
        {
            Comment? c = _commetRepository.GetById(id) ?? throw new Exception("Comment not exist");
            c.Content = comment.Content;            
            return _commetRepository.Update(c);
            
        }
    }
}