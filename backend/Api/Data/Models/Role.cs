using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Data.Models
{
    public class Role
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        // Navigational Property
        public User User { get; set; }

        public Role(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

    }
}
