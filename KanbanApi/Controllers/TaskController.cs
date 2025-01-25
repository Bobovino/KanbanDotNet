using Microsoft.AspNetCore.Mvc;
using KanbanApi.Models;
using KanbanApi.Services;
using System.Collections.Generic;

namespace KanbanApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> GetTasks()
        {
            return Ok(_taskService.GetAllTasks());
        }

        [HttpGet("{id}")]
        public ActionResult<Task> GetTaskById(int id)
        {
            var task = _taskService.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<Task> CreateTask(Task task)
        {
            _taskService.CreateTask(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Task task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            var existingTask = _taskService.GetTaskById(id);
            if (existingTask == null)
            {
                return NotFound();
            }

            _taskService.UpdateTask(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _taskService.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }

            _taskService.DeleteTask(id);
            return NoContent();
        }
    }
}