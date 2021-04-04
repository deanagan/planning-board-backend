using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Data.Models
{
    public class Task
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Summary { get; set; }

        public List<string> Details { get; set;}

        public Task(int id, string summary)
        {
            Id = id;
            Summary = summary;
        }

    }
}
