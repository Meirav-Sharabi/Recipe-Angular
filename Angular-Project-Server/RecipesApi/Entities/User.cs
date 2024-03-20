using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipesApi.Entities
{
    
    public class User
    {
        
        public int code { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }

        public string? email { get; set; }
        public string? password { get; set; }

        public User(int id, string? name, string? address, string? email, string? password)
        {
            this.code = id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.password = password;
        }
        public User()
        {

        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   code == user.code &&
                   name == user.name &&
                   address == user.address &&
                   email == user.email &&
                   password == user.password;
        }
    }
}
