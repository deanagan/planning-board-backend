using System.Collections.Generic;

namespace PlanningBoard.Api.Data.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Summary { get; set; }

        public State State { get; set; }

        public Project Project { get; set; }

        public User User { get; set; }

        public ICollection<TaskDetail> TaskDetails { get; set; }

    }
}
