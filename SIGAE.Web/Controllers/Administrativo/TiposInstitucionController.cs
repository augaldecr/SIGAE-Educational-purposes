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
    public class TiposInstitucionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposInstitucionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposInstitucion
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoInstitucion.ToListAsync());
        }

        // GET: TiposInstitucion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoInstitucion = await _context.TipoInstitucion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoInstitucion == null)
            {
                return NotFound();
            }

            return View(tipoInstitucion);
        }

        // GET: TiposInstitucion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposInstitucion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoInstitucion tipoInstitucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoInstitucion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoInstitucion);
        }

        // GET: TiposInstitucion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoInstitucion = await _context.TipoInstitucion.FindAsync(id);
            if (tipoInstitucion == null)
            {
                return NotFound();
            }
            return View(tipoInstitucion);
        }

        // POST: TiposInstitucion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoInstitucion tipoInstitucion)
        {
            if (id != tipoInstitucion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoInstitucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoInstitucionExists(tipoInstitucion.Id))
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
            return View(tipoInstitucion);
        }

        // GET: TiposInstitucion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoInstitucion = await _context.TipoInstitucion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoInstitucion == null)
            {
                return NotFound();
            }

            return View(tipoInstitucion);
        }

        // POST: TiposInstitucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoInstitucion = await _context.TipoInstitucion.FindAsync(id);
            _context.TipoInstitucion.Remove(tipoInstitucion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoInstitucionExists(int id)
        {
            return _context.TipoInstitucion.Any(e => e.Id == id);
        }
    }
}
