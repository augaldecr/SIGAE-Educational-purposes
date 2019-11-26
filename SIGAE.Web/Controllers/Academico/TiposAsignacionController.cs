using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Academico;

namespace SIGAE.Web.Controllers.Academico
{
    public class TiposAsignacionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposAsignacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposAsignacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposAsignacion.ToListAsync());
        }

        // GET: TiposAsignacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsignacion = await _context.TiposAsignacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoAsignacion == null)
            {
                return NotFound();
            }

            return View(tipoAsignacion);
        }

        // GET: TiposAsignacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposAsignacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoAsignacion tipoAsignacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAsignacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAsignacion);
        }

        // GET: TiposAsignacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsignacion = await _context.TiposAsignacion.FindAsync(id);
            if (tipoAsignacion == null)
            {
                return NotFound();
            }
            return View(tipoAsignacion);
        }

        // POST: TiposAsignacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoAsignacion tipoAsignacion)
        {
            if (id != tipoAsignacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAsignacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAsignacionExists(tipoAsignacion.Id))
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
            return View(tipoAsignacion);
        }

        // GET: TiposAsignacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsignacion = await _context.TiposAsignacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoAsignacion == null)
            {
                return NotFound();
            }

            return View(tipoAsignacion);
        }

        // POST: TiposAsignacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAsignacion = await _context.TiposAsignacion.FindAsync(id);
            _context.TiposAsignacion.Remove(tipoAsignacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAsignacionExists(int id)
        {
            return _context.TiposAsignacion.Any(e => e.Id == id);
        }
    }
}
