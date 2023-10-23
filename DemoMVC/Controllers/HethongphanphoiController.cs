using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HethongphanphoiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HethongphanphoiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hethongphanphoi
        public async Task<IActionResult> Index()
        {
              return _context.Hethongphanphoi != null ? 
                          View(await _context.Hethongphanphoi.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Hethongphanphoi'  is null.");
        }

        // GET: Hethongphanphoi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Hethongphanphoi == null)
            {
                return NotFound();
            }

            var hethongphanphoi = await _context.Hethongphanphoi
                .FirstOrDefaultAsync(m => m.Madaily == id);
            if (hethongphanphoi == null)
            {
                return NotFound();
            }

            return View(hethongphanphoi);
        }

        // GET: Hethongphanphoi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hethongphanphoi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Madaily,Tendaily,Diachi,Nguoidaidien,Dienthoai,MaHTPP")] Hethongphanphoi hethongphanphoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hethongphanphoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hethongphanphoi);
        }

        // GET: Hethongphanphoi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Hethongphanphoi == null)
            {
                return NotFound();
            }

            var hethongphanphoi = await _context.Hethongphanphoi.FindAsync(id);
            if (hethongphanphoi == null)
            {
                return NotFound();
            }
            return View(hethongphanphoi);
        }

        // POST: Hethongphanphoi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Madaily,Tendaily,Diachi,Nguoidaidien,Dienthoai,MaHTPP")] Hethongphanphoi hethongphanphoi)
        {
            if (id != hethongphanphoi.Madaily)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hethongphanphoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HethongphanphoiExists(hethongphanphoi.Madaily))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hethongphanphoi);
        }

        // GET: Hethongphanphoi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Hethongphanphoi == null)
            {
                return NotFound();
            }

            var hethongphanphoi = await _context.Hethongphanphoi
                .FirstOrDefaultAsync(m => m.Madaily == id);
            if (hethongphanphoi == null)
            {
                return NotFound();
            }

            return View(hethongphanphoi);
        }

        // POST: Hethongphanphoi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Hethongphanphoi == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hethongphanphoi'  is null.");
            }
            var hethongphanphoi = await _context.Hethongphanphoi.FindAsync(id);
            if (hethongphanphoi != null)
            {
                _context.Hethongphanphoi.Remove(hethongphanphoi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HethongphanphoiExists(string id)
        {
          return (_context.Hethongphanphoi?.Any(e => e.Madaily == id)).GetValueOrDefault();
        }
    }
}
