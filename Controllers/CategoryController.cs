using Microsoft.AspNetCore.Mvc;
using TodoApps.Context;
using TodoApps.Models;

namespace TodoApps.Controllers
{
   
        

        public class CategoryController : Controller
        {
            private readonly ApplicationDbContext _context;
            public CategoryController(ApplicationDbContext context)
            {
                _context = context;
            }



            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Category obj)
            {
                if (ModelState.IsValid)
                {
                    _context.Categories.Add(obj);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));

                }
                return View(obj);
            }
            public IActionResult Index()
            {
                var categories = _context.Categories.ToList();

                return View(categories);
            }

            public IActionResult Update(int? Id)
            {
                if (Id is null)
                {
                    return BadRequest();
                }
                var cat = _context.Categories.FirstOrDefault(C => C.Id == Id);
                if (cat is null)
                {
                    return NotFound();
                }


                return View(cat);
            }

            [HttpPost]
            public IActionResult Update(Category obj)
            {
                if (ModelState.IsValid)
                {
                    _context.Categories.Update(obj);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                return View(obj);
            }

            public IActionResult Remove(int id)
            {


                var obj = _context.Categories.FirstOrDefault(c => c.Id == id);
                _context.Categories.Remove(obj);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));


            }

        }
    }
