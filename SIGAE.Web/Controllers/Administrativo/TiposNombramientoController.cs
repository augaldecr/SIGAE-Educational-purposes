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
    public class TiposNombramientoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposNombramientoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposNombramiento
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposNombramiento.ToListAsync());
        }

        // GET: TiposNombramiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoNombramiento = await _context.TiposNombramiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoNombramiento == null)
            {
                return NotFound();
            }

            return View(tipoNombramiento);
        }

        // GET: TiposNombramiento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposNombramiento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoNombramiento tipoNombramiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoNombramiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoNombramiento);
        }

        // GET: TiposNombramiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoNombramiento = await _context.TiposNombramiento.FindAsync(id);
            if (tipoNombramiento == null)
            {
                return NotFound();
            }
            return View(tipoNombramiento);
        }

        // POST: TiposNombramiento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoNombramiento tipoNombramiento)
        {
            if (id != tipoNombramiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoNombramiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoNombramientoExists(tipoNombramiento.Id))
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
            return View(tipoNombramiento);
        }

        // GET: TiposNombramiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoNombramiento = await _context.TiposNombramiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoNombramiento == null)
            {
                return NotFound();
            }

            return View(tipoNombramiento);
        }

        // POST: TiposNombramiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoNombramiento = await _context.TiposNombramiento.FindAsync(id);
            _context.TiposNombramiento.Remove(tipoNombramiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoNombramientoExists(int id)
        {
            return _context.TiposNombramiento.Any(e => e.Id == id);
        }
    }
}
