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
    public class TiposGastoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposGastoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposGasto
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposGasto.ToListAsync());
        }

        // GET: TiposGasto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoGasto = await _context.TiposGasto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoGasto == null)
            {
                return NotFound();
            }

            return View(tipoGasto);
        }

        // GET: TiposGasto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposGasto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoGasto tipoGasto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoGasto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoGasto);
        }

        // GET: TiposGasto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoGasto = await _context.TiposGasto.FindAsync(id);
            if (tipoGasto == null)
            {
                return NotFound();
            }
            return View(tipoGasto);
        }

        // POST: TiposGasto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoGasto tipoGasto)
        {
            if (id != tipoGasto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoGasto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoGastoExists(tipoGasto.Id))
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
            return View(tipoGasto);
        }

        // GET: TiposGasto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoGasto = await _context.TiposGasto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoGasto == null)
            {
                return NotFound();
            }

            return View(tipoGasto);
        }

        // POST: TiposGasto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoGasto = await _context.TiposGasto.FindAsync(id);
            _context.TiposGasto.Remove(tipoGasto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoGastoExists(int id)
        {
            return _context.TiposGasto.Any(e => e.Id == id);
        }
    }
}
