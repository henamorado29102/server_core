using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Dto;
using core.Models;

namespace core.Service.Interface
{
    public interface IUserService
    {
        
        User? GetById(int id);        
        List<User> GetAll();
        Task<List<User>> GetAllPaginate(int pageIndex, int pageSize);
        bool Delete(int id);
        User? Update(int id, UserDto user);
        User Save(User user);        
    }
}