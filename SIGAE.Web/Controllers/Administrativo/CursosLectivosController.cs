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
    public class CursosLectivosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CursosLectivosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CursosLectivos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CursosLectivos.ToListAsync());
        }

        // GET: CursosLectivos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoLectivo = await _context.CursosLectivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursoLectivo == null)
            {
                return NotFound();
            }

            return View(cursoLectivo);
        }

        // GET: CursosLectivos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CursosLectivos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Anio,Actual")] CursoLectivo cursoLectivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cursoLectivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cursoLectivo);
        }

        // GET: CursosLectivos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoLectivo = await _context.CursosLectivos.FindAsync(id);
            if (cursoLectivo == null)
            {
                return NotFound();
            }
            return View(cursoLectivo);
        }

        // POST: CursosLectivos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Anio,Actual")] CursoLectivo cursoLectivo)
        {
            if (id != cursoLectivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cursoLectivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoLectivoExists(cursoLectivo.Id))
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
            return View(cursoLectivo);
        }

        // GET: CursosLectivos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoLectivo = await _context.CursosLectivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursoLectivo == null)
            {
                return NotFound();
            }

            return View(cursoLectivo);
        }

        // POST: CursosLectivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cursoLectivo = await _context.CursosLectivos.FindAsync(id);
            _context.CursosLectivos.Remove(cursoLectivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoLectivoExists(int id)
        {
            return _context.CursosLectivos.Any(e => e.Id == id);
        }
    }
}
