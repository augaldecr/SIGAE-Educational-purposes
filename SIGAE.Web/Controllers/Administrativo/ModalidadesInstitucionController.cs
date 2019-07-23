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
    public class ModalidadesInstitucionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModalidadesInstitucionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ModalidadesInstitucion
        public async Task<IActionResult> Index()
        {
            return View(await _context.ModalidadInstitucion.ToListAsync());
        }

        // GET: ModalidadesInstitucion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidadInstitucion = await _context.ModalidadInstitucion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalidadInstitucion == null)
            {
                return NotFound();
            }

            return View(modalidadInstitucion);
        }

        // GET: ModalidadesInstitucion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ModalidadesInstitucion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] ModalidadInstitucion modalidadInstitucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modalidadInstitucion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modalidadInstitucion);
        }

        // GET: ModalidadesInstitucion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidadInstitucion = await _context.ModalidadInstitucion.FindAsync(id);
            if (modalidadInstitucion == null)
            {
                return NotFound();
            }
            return View(modalidadInstitucion);
        }

        // POST: ModalidadesInstitucion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] ModalidadInstitucion modalidadInstitucion)
        {
            if (id != modalidadInstitucion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modalidadInstitucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModalidadInstitucionExists(modalidadInstitucion.Id))
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
            return View(modalidadInstitucion);
        }

        // GET: ModalidadesInstitucion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidadInstitucion = await _context.ModalidadInstitucion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalidadInstitucion == null)
            {
                return NotFound();
            }

            return View(modalidadInstitucion);
        }

        // POST: ModalidadesInstitucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modalidadInstitucion = await _context.ModalidadInstitucion.FindAsync(id);
            _context.ModalidadInstitucion.Remove(modalidadInstitucion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModalidadInstitucionExists(int id)
        {
            return _context.ModalidadInstitucion.Any(e => e.Id == id);
        }
    }
}
