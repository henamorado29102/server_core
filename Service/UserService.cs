using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Dto;
using core.Models;
using core.Repository.Interface;
using core.Service.Interface;

namespace core.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User Save(User user)
        {
            return _userRepository.Save(user);
        }

        public User? Update(int id, UserDto user)
        {
            User? u = _userRepository.GetById(id);
            if (u != null){
                u.Name = user.Name;
                u.Email = user.Email;
                u.Lastname = user.Lastname;
                _userRepository.Update(u);
;           }
            return u ?? null;
        }
    }
}