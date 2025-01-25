using System.Collections.Generic;
using System.Linq;
using KanbanApi.Models;

namespace KanbanApi.Services
{
    public class TaskService
    {
        private readonly List<Task> _tasks = new List<Task>();

        public IEnumerable<Task> GetAllTasks()
        {
            return _tasks;
        }

        public Task GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public void CreateTask(Task task)
        {
            _tasks.Add(task);
        }

        public void UpdateTask(Task task)
        {
            var existingTask = GetTaskById(task.Id);
            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.Status = task.Status;
                existingTask.BoardId = task.BoardId;
            }
        }

        public void DeleteTask(int id)
        {
            var task = GetTaskById(id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }
    }
}