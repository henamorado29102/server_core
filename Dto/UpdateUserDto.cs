using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Dto
{
    public class UpdateUserDto
    {         
        public int Id { get; set; } 
        public string Name { get; set;} = string.Empty;
        public string Lastname { get; set;} = string.Empty;
        public string Email { get; set;} = string.Empty;

        public UpdateUserDto(){
        }

       
    }
}