using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo;

namespace SIGAE.Web.Controllers.Administrativo
{
    public class RegionalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegionalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Regionales
        public async Task<IActionResult> Index()
        {
            return View(await _context.Regional.ToListAsync());
        }

        // GET: Regionales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regional = await _context.Regional
                .FirstOrDefaultAsync(m => m.Id == id);
            if (regional == null)
            {
                return NotFound();
            }

            return View(regional);
        }

        // GET: Regionales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Regionales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Regional regional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(regional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(regional);
        }

        // GET: Regionales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regional = await _context.Regional.FindAsync(id);
            if (regional == null)
            {
                return NotFound();
            }
            return View(regional);
        }

        // POST: Regionales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Regional regional)
        {
            if (id != regional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(regional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegionalExists(regional.Id))
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
            return View(regional);
        }

        // GET: Regionales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regional = await _context.Regional
                .FirstOrDefaultAsync(m => m.Id == id);
            if (regional == null)
            {
                return NotFound();
            }

            return View(regional);
        }

        // POST: Regionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var regional = await _context.Regional.FindAsync(id);
            _context.Regional.Remove(regional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegionalExists(int id)
        {
            return _context.Regional.Any(e => e.Id == id);
        }
    }
}
