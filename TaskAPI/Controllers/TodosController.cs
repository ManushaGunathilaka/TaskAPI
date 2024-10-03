using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic; // Make sure to include this namespace
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = CreateTodos();
            return Ok(todos); // Return the list of todos
        }

        private List<Todo> CreateTodos()
        {
            var todos = new List<Todo>();

            // Create three Todo items
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test 1",
                Description = "Description for Test 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.Status.New
            };
            
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test 2",
                Description = "Description for Test 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Status.Inprogress
            };

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test 3",
                Description = "Description for Test 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.Status.Completed
            };

            // Add the todos to the list
            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(todo3);

            return todos; // Return the list of todos
        }
    }
}
