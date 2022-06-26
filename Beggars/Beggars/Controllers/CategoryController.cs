using Beggars.Data;
using Beggars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beggars.Controllers
{
    public class CategoryController : Controller
    {
        public ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext db)
        {
            _context = db;
        }

        public IActionResult Index()
        {
            var data = _context.Category.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category Cat)
        {
            _context.Category.Add(Cat);
            _context.SaveChanges();
            return RedirectToAction("Index");
         
        }

        [HttpGet]
        public IActionResult Edit(int ?id)
        {
            var c= _context.Category.Where(x=> x.Id==id).First();
            return View(c);
        }
        [HttpPost]
        public IActionResult Edit(Category Cat)
        {
            _context.Category.Update(Cat);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }

}
