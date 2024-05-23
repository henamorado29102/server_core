using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Data;
using core.Models;
using core.Repository.Interface;

namespace core.Repository
{
    public class UserRepository : IUserRepository
    {

        private ApplicationDBContext context;

        public UserRepository(ApplicationDBContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            User? user = context.User.Find(id);
            if (user == null){
                return false;
            }
            context.User.Remove(user);
            return true;
        }

        public List<User> GetAll()
        {
            return context.User.ToList();
        }

        public User? GetById(int id)
        {
            var u = context.User.Find(id);
            return u;
        }

        public User Save(User user)
        {
           context.User.Add(user);
           context.SaveChanges();
           return user;
        }

        public User Update(User user)
        {
            context.User.Update(user);
            context.SaveChanges();
            return user;
        }
    }
}