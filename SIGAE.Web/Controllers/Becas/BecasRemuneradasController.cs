using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Becas;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Controllers.Becas
{
    public class BecasRemuneradasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BecasRemuneradasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BecasRemuneradas
        public async Task<IActionResult> Index()
        {
            return View(await _context.BecaRemunerada.ToListAsync());
        }

        // GET: BecasRemuneradas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var becaRemunerada = await _context.BecaRemunerada
                .FirstOrDefaultAsync(m => m.Id == id);
            if (becaRemunerada == null)
            {
                return NotFound();
            }

            return View(becaRemunerada);
        }

        // GET: BecasRemuneradas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BecasRemuneradas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Monto,Id,Nombre")] BecaRemunerada becaRemunerada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(becaRemunerada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(becaRemunerada);
        }

        // GET: BecasRemuneradas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var becaRemunerada = await _context.BecaRemunerada.FindAsync(id);
            if (becaRemunerada == null)
            {
                return NotFound();
            }
            return View(becaRemunerada);
        }

        // POST: BecasRemuneradas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Monto,Id,Nombre")] BecaRemunerada becaRemunerada)
        {
            if (id != becaRemunerada.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(becaRemunerada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BecaRemuneradaExists(becaRemunerada.Id))
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
            return View(becaRemunerada);
        }

        // GET: BecasRemuneradas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var becaRemunerada = await _context.BecaRemunerada
                .FirstOrDefaultAsync(m => m.Id == id);
            if (becaRemunerada == null)
            {
                return NotFound();
            }

            return View(becaRemunerada);
        }

        // POST: BecasRemuneradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var becaRemunerada = await _context.BecaRemunerada.FindAsync(id);
            _context.BecaRemunerada.Remove(becaRemunerada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BecaRemuneradaExists(int id)
        {
            return _context.BecaRemunerada.Any(e => e.Id == id);
        }
    }
}
