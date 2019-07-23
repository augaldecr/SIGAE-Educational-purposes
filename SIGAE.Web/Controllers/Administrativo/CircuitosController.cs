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
    public class CircuitosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CircuitosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Circuitos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Circuito.ToListAsync());
        }

        // GET: Circuitos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var circuito = await _context.Circuito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (circuito == null)
            {
                return NotFound();
            }

            return View(circuito);
        }

        // GET: Circuitos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Circuitos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Circuito circuito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(circuito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circuito);
        }

        // GET: Circuitos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var circuito = await _context.Circuito.FindAsync(id);
            if (circuito == null)
            {
                return NotFound();
            }
            return View(circuito);
        }

        // POST: Circuitos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Circuito circuito)
        {
            if (id != circuito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(circuito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CircuitoExists(circuito.Id))
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
            return View(circuito);
        }

        // GET: Circuitos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var circuito = await _context.Circuito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (circuito == null)
            {
                return NotFound();
            }

            return View(circuito);
        }

        // POST: Circuitos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var circuito = await _context.Circuito.FindAsync(id);
            _context.Circuito.Remove(circuito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CircuitoExists(int id)
        {
            return _context.Circuito.Any(e => e.Id == id);
        }
    }
}
