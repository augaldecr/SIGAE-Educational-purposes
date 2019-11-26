using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;

namespace SIGAE.Web.Controllers.Administrativo.Asesoria
{
    public class TiposTransporteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposTransporteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposTransporte
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposTransporte.ToListAsync());
        }

        // GET: TiposTransporte/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTransporte = await _context.TiposTransporte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoTransporte == null)
            {
                return NotFound();
            }

            return View(tipoTransporte);
        }

        // GET: TiposTransporte/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposTransporte/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoTransporte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoTransporte);
        }

        // GET: TiposTransporte/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTransporte = await _context.TiposTransporte.FindAsync(id);
            if (tipoTransporte == null)
            {
                return NotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TiposTransporte/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoTransporte tipoTransporte)
        {
            if (id != tipoTransporte.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoTransporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoTransporteExists(tipoTransporte.Id))
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
            return View(tipoTransporte);
        }

        // GET: TiposTransporte/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTransporte = await _context.TiposTransporte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoTransporte == null)
            {
                return NotFound();
            }

            return View(tipoTransporte);
        }

        // POST: TiposTransporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoTransporte = await _context.TiposTransporte.FindAsync(id);
            _context.TiposTransporte.Remove(tipoTransporte);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoTransporteExists(int id)
        {
            return _context.TiposTransporte.Any(e => e.Id == id);
        }
    }
}
