using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;

namespace core.Repository.Interface
{
    public interface IUserRepository
    {
        User? GetById(int id);        
        List<User> GetAll();
        bool Delete(int id);
        User Update(User user);
        User Save(User user);        
    }
}