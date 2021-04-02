using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Data.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Role Role { get; set;}

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string Hash { get; set; }

        public User(int id, string name, Role role, string email, string hash)
        {
            Id = id;
            Name = name;
            Role = role;
            Email = email;
            Hash = hash;
        }

    }
}
