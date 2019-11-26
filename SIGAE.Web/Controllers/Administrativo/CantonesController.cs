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
    public class CantonesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CantonesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cantones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cantones.ToListAsync());
        }

        // GET: Cantones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canton = await _context.Cantones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (canton == null)
            {
                return NotFound();
            }

            return View(canton);
        }

        // GET: Cantones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cantones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Canton canton)
        {
            if (ModelState.IsValid)
            {
                _context.Add(canton);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(canton);
        }

        // GET: Cantones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canton = await _context.Cantones.FindAsync(id);
            if (canton == null)
            {
                return NotFound();
            }
            return View(canton);
        }

        // POST: Cantones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Canton canton)
        {
            if (id != canton.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(canton);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CantonExists(canton.Id))
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
            return View(canton);
        }

        // GET: Cantones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canton = await _context.Cantones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (canton == null)
            {
                return NotFound();
            }

            return View(canton);
        }

        // POST: Cantones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var canton = await _context.Cantones.FindAsync(id);
            _context.Cantones.Remove(canton);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CantonExists(int id)
        {
            return _context.Cantones.Any(e => e.Id == id);
        }
    }
}
