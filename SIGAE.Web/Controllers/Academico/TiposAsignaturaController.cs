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
    public class TiposAsignaturaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposAsignaturaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposAsignatura
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoAsignatura.ToListAsync());
        }

        // GET: TiposAsignatura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsignatura = await _context.TipoAsignatura
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoAsignatura == null)
            {
                return NotFound();
            }

            return View(tipoAsignatura);
        }

        // GET: TiposAsignatura/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposAsignatura/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoAsignatura tipoAsignatura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAsignatura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAsignatura);
        }

        // GET: TiposAsignatura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsignatura = await _context.TipoAsignatura.FindAsync(id);
            if (tipoAsignatura == null)
            {
                return NotFound();
            }
            return View(tipoAsignatura);
        }

        // POST: TiposAsignatura/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoAsignatura tipoAsignatura)
        {
            if (id != tipoAsignatura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAsignatura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAsignaturaExists(tipoAsignatura.Id))
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
            return View(tipoAsignatura);
        }

        // GET: TiposAsignatura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsignatura = await _context.TipoAsignatura
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoAsignatura == null)
            {
                return NotFound();
            }

            return View(tipoAsignatura);
        }

        // POST: TiposAsignatura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAsignatura = await _context.TipoAsignatura.FindAsync(id);
            _context.TipoAsignatura.Remove(tipoAsignatura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAsignaturaExists(int id)
        {
            return _context.TipoAsignatura.Any(e => e.Id == id);
        }
    }
}
