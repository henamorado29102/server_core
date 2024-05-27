using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Data;
using Microsoft.EntityFrameworkCore;

namespace core.Repository.Interface
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly ApplicationDBContext _context;

        public Repository(ApplicationDBContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;

        }

        public bool Delete(T entity)
        {
             return _dbSet.Remove(entity).State == EntityState.Deleted;
             
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
            T? entity = _dbSet.Find(id);
            return entity;
        }

        public T Save(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            _dbSet.Attach(entity);            
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}