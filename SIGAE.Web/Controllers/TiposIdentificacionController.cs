using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;

namespace SIGAE.Web.Controllers
{
    public class TiposIdentificacionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposIdentificacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposIdentificacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposIdentificacion.ToListAsync());
        }

        // GET: TiposIdentificacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoIdentificacion = await _context.TiposIdentificacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoIdentificacion == null)
            {
                return NotFound();
            }

            return View(tipoIdentificacion);
        }

        // GET: TiposIdentificacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposIdentificacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoIdentificacion tipoIdentificacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoIdentificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoIdentificacion);
        }

        // GET: TiposIdentificacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoIdentificacion = await _context.TiposIdentificacion.FindAsync(id);
            if (tipoIdentificacion == null)
            {
                return NotFound();
            }
            return View(tipoIdentificacion);
        }

        // POST: TiposIdentificacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoIdentificacion tipoIdentificacion)
        {
            if (id != tipoIdentificacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoIdentificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoIdentificacionExists(tipoIdentificacion.Id))
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
            return View(tipoIdentificacion);
        }

        // GET: TiposIdentificacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoIdentificacion = await _context.TiposIdentificacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoIdentificacion == null)
            {
                return NotFound();
            }

            return View(tipoIdentificacion);
        }

        // POST: TiposIdentificacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoIdentificacion = await _context.TiposIdentificacion.FindAsync(id);
            _context.TiposIdentificacion.Remove(tipoIdentificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoIdentificacionExists(int id)
        {
            return _context.TiposIdentificacion.Any(e => e.Id == id);
        }
    }
}
