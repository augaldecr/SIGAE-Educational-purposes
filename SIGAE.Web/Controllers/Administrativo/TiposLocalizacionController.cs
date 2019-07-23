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
    public class TiposLocalizacionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposLocalizacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposLocalizacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoLocalizacion.ToListAsync());
        }

        // GET: TiposLocalizacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoLocalizacion = await _context.TipoLocalizacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoLocalizacion == null)
            {
                return NotFound();
            }

            return View(tipoLocalizacion);
        }

        // GET: TiposLocalizacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposLocalizacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoLocalizacion tipoLocalizacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoLocalizacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoLocalizacion);
        }

        // GET: TiposLocalizacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoLocalizacion = await _context.TipoLocalizacion.FindAsync(id);
            if (tipoLocalizacion == null)
            {
                return NotFound();
            }
            return View(tipoLocalizacion);
        }

        // POST: TiposLocalizacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoLocalizacion tipoLocalizacion)
        {
            if (id != tipoLocalizacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoLocalizacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoLocalizacionExists(tipoLocalizacion.Id))
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
            return View(tipoLocalizacion);
        }

        // GET: TiposLocalizacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoLocalizacion = await _context.TipoLocalizacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoLocalizacion == null)
            {
                return NotFound();
            }

            return View(tipoLocalizacion);
        }

        // POST: TiposLocalizacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoLocalizacion = await _context.TipoLocalizacion.FindAsync(id);
            _context.TipoLocalizacion.Remove(tipoLocalizacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoLocalizacionExists(int id)
        {
            return _context.TipoLocalizacion.Any(e => e.Id == id);
        }
    }
}
