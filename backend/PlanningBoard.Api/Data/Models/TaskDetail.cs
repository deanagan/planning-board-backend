
namespace PlanningBoard.Api.Data.Models
{
    public class TaskDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool isDone { get; set; }

        public Task Task { get; set; }
    }
}
