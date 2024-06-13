using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;

namespace core.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        T? GetById(int id);        
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(int pageIndex, int pageSize);
        bool Delete(T entity);
        T Update(T entity);
        T Save(T entity);        
    }
}