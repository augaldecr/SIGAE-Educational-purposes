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
    public class TiposPuestoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposPuestoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposPuesto
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposPuesto.ToListAsync());
        }

        // GET: TiposPuesto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPuesto = await _context.TiposPuesto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPuesto == null)
            {
                return NotFound();
            }

            return View(tipoPuesto);
        }

        // GET: TiposPuesto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposPuesto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoPuesto tipoPuesto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPuesto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPuesto);
        }

        // GET: TiposPuesto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPuesto = await _context.TiposPuesto.FindAsync(id);
            if (tipoPuesto == null)
            {
                return NotFound();
            }
            return View(tipoPuesto);
        }

        // POST: TiposPuesto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoPuesto tipoPuesto)
        {
            if (id != tipoPuesto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPuesto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPuestoExists(tipoPuesto.Id))
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
            return View(tipoPuesto);
        }

        // GET: TiposPuesto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPuesto = await _context.TiposPuesto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPuesto == null)
            {
                return NotFound();
            }

            return View(tipoPuesto);
        }

        // POST: TiposPuesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPuesto = await _context.TiposPuesto.FindAsync(id);
            _context.TiposPuesto.Remove(tipoPuesto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPuestoExists(int id)
        {
            return _context.TiposPuesto.Any(e => e.Id == id);
        }
    }
}
