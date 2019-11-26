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
    public class TiposEvaluacionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposEvaluacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposEvaluacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposEvaluacion.ToListAsync());
        }

        // GET: TiposEvaluacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoEvaluacion = await _context.TiposEvaluacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoEvaluacion == null)
            {
                return NotFound();
            }

            return View(tipoEvaluacion);
        }

        // GET: TiposEvaluacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposEvaluacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoEvaluacion tipoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoEvaluacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoEvaluacion);
        }

        // GET: TiposEvaluacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoEvaluacion = await _context.TiposEvaluacion.FindAsync(id);
            if (tipoEvaluacion == null)
            {
                return NotFound();
            }
            return View(tipoEvaluacion);
        }

        // POST: TiposEvaluacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoEvaluacion tipoEvaluacion)
        {
            if (id != tipoEvaluacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoEvaluacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoEvaluacionExists(tipoEvaluacion.Id))
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
            return View(tipoEvaluacion);
        }

        // GET: TiposEvaluacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoEvaluacion = await _context.TiposEvaluacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoEvaluacion == null)
            {
                return NotFound();
            }

            return View(tipoEvaluacion);
        }

        // POST: TiposEvaluacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoEvaluacion = await _context.TiposEvaluacion.FindAsync(id);
            _context.TiposEvaluacion.Remove(tipoEvaluacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoEvaluacionExists(int id)
        {
            return _context.TiposEvaluacion.Any(e => e.Id == id);
        }
    }
}
