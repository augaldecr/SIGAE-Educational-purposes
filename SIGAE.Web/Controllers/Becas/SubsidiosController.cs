using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Becas;

namespace SIGAE.Web.Controllers.Becas
{
    public class SubsidiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubsidiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Subsidios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subsidio.ToListAsync());
        }

        // GET: Subsidios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subsidio = await _context.Subsidio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subsidio == null)
            {
                return NotFound();
            }

            return View(subsidio);
        }

        // GET: Subsidios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subsidios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Subsidio subsidio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subsidio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subsidio);
        }

        // GET: Subsidios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subsidio = await _context.Subsidio.FindAsync(id);
            if (subsidio == null)
            {
                return NotFound();
            }
            return View(subsidio);
        }

        // POST: Subsidios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Subsidio subsidio)
        {
            if (id != subsidio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subsidio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubsidioExists(subsidio.Id))
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
            return View(subsidio);
        }

        // GET: Subsidios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subsidio = await _context.Subsidio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subsidio == null)
            {
                return NotFound();
            }

            return View(subsidio);
        }

        // POST: Subsidios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subsidio = await _context.Subsidio.FindAsync(id);
            _context.Subsidio.Remove(subsidio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubsidioExists(int id)
        {
            return _context.Subsidio.Any(e => e.Id == id);
        }
    }
}
