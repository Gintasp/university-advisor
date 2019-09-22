using System.ComponentModel.DataAnnotations.Schema;

namespace Advisor.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string email, string name, string password)
        {
            Email = email;
            Name = name;
            Password = password;
        }
    }
}
