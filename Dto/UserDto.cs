using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Dto
{
    public class UserDto
    {         
        public string Name { get; set;} = string.Empty;
        public string Lastname { get; set;} = string.Empty;
        public string Email { get; set;} = string.Empty;

        public UserDto(){
        }

        public UserDto(string name, string lastname, string email)
        {            
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
        }
    }
}