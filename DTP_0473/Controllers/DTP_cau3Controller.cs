using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DTP_0473.Models;

namespace DTP_0473.Controllers
{
    public class DTP_cau3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public DTP_cau3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DTP_cau3
        public async Task<IActionResult> Index()
        {
              return _context.DTP_cau3 != null ? 
                          View(await _context.DTP_cau3.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.DTP_cau3'  is null.");
        }

        // GET: DTP_cau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.DTP_cau3 == null)
            {
                return NotFound();
            }

            var dTP_cau3 = await _context.DTP_cau3
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (dTP_cau3 == null)
            {
                return NotFound();
            }

            return View(dTP_cau3);
        }

        // GET: DTP_cau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTP_cau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Masinhvien,Hovaten,Diachi")] DTP_cau3 dTP_cau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTP_cau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTP_cau3);
        }

        // GET: DTP_cau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.DTP_cau3 == null)
            {
                return NotFound();
            }

            var dTP_cau3 = await _context.DTP_cau3.FindAsync(id);
            if (dTP_cau3 == null)
            {
                return NotFound();
            }
            return View(dTP_cau3);
        }

        // POST: DTP_cau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masinhvien,Hovaten,Diachi")] DTP_cau3 dTP_cau3)
        {
            if (id != dTP_cau3.Masinhvien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTP_cau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTP_cau3Exists(dTP_cau3.Masinhvien))
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
            return View(dTP_cau3);
        }

        // GET: DTP_cau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.DTP_cau3 == null)
            {
                return NotFound();
            }

            var dTP_cau3 = await _context.DTP_cau3
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (dTP_cau3 == null)
            {
                return NotFound();
            }

            return View(dTP_cau3);
        }

        // POST: DTP_cau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.DTP_cau3 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DTP_cau3'  is null.");
            }
            var dTP_cau3 = await _context.DTP_cau3.FindAsync(id);
            if (dTP_cau3 != null)
            {
                _context.DTP_cau3.Remove(dTP_cau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTP_cau3Exists(string id)
        {
          return (_context.DTP_cau3?.Any(e => e.Masinhvien == id)).GetValueOrDefault();
        }
    }
}
