

namespace core.Models
{
    public class User
    {
        public int Id { get; set;}
        public string Name { get; set;} = string.Empty;
        public string Lastname { get; set;} = string.Empty;
        public string Email { get; set;} = string.Empty;

        public User(){
        }

        public User(string name, string lastname, string email)
        {            
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
        }
    }
}