using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Becas;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Controllers.Becas
{
    public class TiposBecaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TiposBecaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TiposBeca
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoBeca.ToListAsync());
        }

        // GET: TiposBeca/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoBeca = await _context.TipoBeca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoBeca == null)
            {
                return NotFound();
            }

            return View(tipoBeca);
        }

        // GET: TiposBeca/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposBeca/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoBeca tipoBeca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoBeca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoBeca);
        }

        // GET: TiposBeca/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoBeca = await _context.TipoBeca.FindAsync(id);
            if (tipoBeca == null)
            {
                return NotFound();
            }
            return View(tipoBeca);
        }

        // POST: TiposBeca/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoBeca tipoBeca)
        {
            if (id != tipoBeca.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoBeca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoBecaExists(tipoBeca.Id))
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
            return View(tipoBeca);
        }

        // GET: TiposBeca/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoBeca = await _context.TipoBeca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoBeca == null)
            {
                return NotFound();
            }

            return View(tipoBeca);
        }

        // POST: TiposBeca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoBeca = await _context.TipoBeca.FindAsync(id);
            _context.TipoBeca.Remove(tipoBeca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoBecaExists(int id)
        {
            return _context.TipoBeca.Any(e => e.Id == id);
        }
    }
}
