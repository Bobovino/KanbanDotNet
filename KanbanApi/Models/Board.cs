using System.Collections.Generic;

namespace KanbanApi.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}