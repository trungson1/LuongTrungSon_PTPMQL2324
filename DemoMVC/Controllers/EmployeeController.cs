using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            var model = await _context.Employees.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee epl)
        {
            if(ModelState.IsValid)
            {
                _context.Add(epl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(epl);
        }
        private bool EmployeeExists(string id)
        {
            return _context.Employees.Any(e => e.EmployeeID == id);
        }
    }
}