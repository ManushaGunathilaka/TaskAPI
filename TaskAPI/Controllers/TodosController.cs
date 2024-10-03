using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic; // Make sure to include this namespace
using TaskApi.Services;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if(id is null) { return Ok(myTodos); }

            myTodos = myTodos.Where(t => t.Id == id).ToList();
            return Ok(myTodos); // Return the list of todos
        }

        
    }
}
