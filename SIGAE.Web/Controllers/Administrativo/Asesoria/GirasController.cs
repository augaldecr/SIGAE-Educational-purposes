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
    public class GirasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GirasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Giras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gira.ToListAsync());
        }

        // GET: Giras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gira = await _context.Gira
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gira == null)
            {
                return NotFound();
            }

            return View(gira);
        }

        // GET: Giras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Giras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,FechaSalida,FechaRegreso,Motivo,Dependencia,Ruta,MontoARESEP")] Gira gira)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gira);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gira);
        }

        // GET: Giras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gira = await _context.Gira.FindAsync(id);
            if (gira == null)
            {
                return NotFound();
            }
            return View(gira);
        }

        // POST: Giras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,FechaSalida,FechaRegreso,Motivo,Dependencia,Ruta,MontoARESEP")] Gira gira)
        {
            if (id != gira.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gira);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiraExists(gira.Id))
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
            return View(gira);
        }

        // GET: Giras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gira = await _context.Gira
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gira == null)
            {
                return NotFound();
            }

            return View(gira);
        }

        // POST: Giras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gira = await _context.Gira.FindAsync(id);
            _context.Gira.Remove(gira);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiraExists(int id)
        {
            return _context.Gira.Any(e => e.Id == id);
        }
    }
}
