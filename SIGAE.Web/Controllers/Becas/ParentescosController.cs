using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Becas;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Controllers.Becas
{
    public class ParentescosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParentescosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Parentescos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parentesco.ToListAsync());
        }

        // GET: Parentescos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentesco
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parentesco == null)
            {
                return NotFound();
            }

            return View(parentesco);
        }

        // GET: Parentescos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parentescos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Parentesco parentesco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parentesco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parentesco);
        }

        // GET: Parentescos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentesco.FindAsync(id);
            if (parentesco == null)
            {
                return NotFound();
            }
            return View(parentesco);
        }

        // POST: Parentescos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Parentesco parentesco)
        {
            if (id != parentesco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parentesco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentescoExists(parentesco.Id))
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
            return View(parentesco);
        }

        // GET: Parentescos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentesco
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parentesco == null)
            {
                return NotFound();
            }

            return View(parentesco);
        }

        // POST: Parentescos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parentesco = await _context.Parentesco.FindAsync(id);
            _context.Parentesco.Remove(parentesco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentescoExists(int id)
        {
            return _context.Parentesco.Any(e => e.Id == id);
        }
    }
}
