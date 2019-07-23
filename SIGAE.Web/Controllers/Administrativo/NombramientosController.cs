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
    public class NombramientosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NombramientosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nombramientos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nombramiento.ToListAsync());
        }

        // GET: Nombramientos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nombramiento = await _context.Nombramiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nombramiento == null)
            {
                return NotFound();
            }

            return View(nombramiento);
        }

        // GET: Nombramientos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nombramientos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaRige,FechaVence")] Nombramiento nombramiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nombramiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nombramiento);
        }

        // GET: Nombramientos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nombramiento = await _context.Nombramiento.FindAsync(id);
            if (nombramiento == null)
            {
                return NotFound();
            }
            return View(nombramiento);
        }

        // POST: Nombramientos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaRige,FechaVence")] Nombramiento nombramiento)
        {
            if (id != nombramiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nombramiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NombramientoExists(nombramiento.Id))
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
            return View(nombramiento);
        }

        // GET: Nombramientos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nombramiento = await _context.Nombramiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nombramiento == null)
            {
                return NotFound();
            }

            return View(nombramiento);
        }

        // POST: Nombramientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nombramiento = await _context.Nombramiento.FindAsync(id);
            _context.Nombramiento.Remove(nombramiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NombramientoExists(int id)
        {
            return _context.Nombramiento.Any(e => e.Id == id);
        }
    }
}
