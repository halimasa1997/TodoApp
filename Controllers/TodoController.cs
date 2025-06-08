using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TodoApps.Context;
using TodoApps.Models;
using TodoApps.ViewsModels;

namespace TodoApps.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // retrieve all todos from the database
            var todos = _context.Todos.ToList();

            return View(todos);
        }

        public IActionResult Create()
        {
            var cats = _context.Categories.ToList();

            TodoViewes viewSModel = new TodoViewes()
            {
                Categories = cats.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()


            };

          return View(viewSModel);
        }

        [HttpPost]
        public IActionResult Create(TodoViewes obj)
        {

            if (ModelState.IsValid)
            {
                Todo todo = new Todo()
                {
                    Name = obj.Name,
                    Description = obj.Description,
                    DueDate = obj.DueDate,
                    CategoryId = obj.CategoryId
                };
                _context.Todos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            var cats = _context.Categories.ToList();
            obj.Categories = cats.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            return View(obj);

        }

    }
}


