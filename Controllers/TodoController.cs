using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VueTest.Models;

namespace VueTest.Controllers
{
    [Route("api/Todo")]
    public class TodoController : Controller
    {
        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() => new OkObjectResult(new[]
        {
            new TodoItem { Id = 1, Text = "Todo 1" },
            new TodoItem { Id = 2, Text = "Todo 2" },
            new TodoItem { Id = 3, Text = "Todo 3" },
        });
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
