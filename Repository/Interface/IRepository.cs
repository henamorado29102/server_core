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
        bool Delete(T entity);
        T Update(T entity);
        T Save(T entity);        
    }
}