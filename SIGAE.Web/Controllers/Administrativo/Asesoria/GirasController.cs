using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using SIGAE.Web.Helpers;
using SIGAE.Web.Models;

namespace SIGAE.Web.Controllers.Administrativo.Asesoria
{
    public class GirasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IGiraHelper girasHelper;
        private readonly IUserHelper userHelper;
        private readonly ILocalidadHelper localidadHelper;

        public GirasController(ApplicationDbContext context,
            IGiraHelper girasHelper,
            IUserHelper userHelper,
            ILocalidadHelper localidadHelper)
        {
            _context = context;
            this.girasHelper = girasHelper;
            this.userHelper = userHelper;
            this.localidadHelper = localidadHelper;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userHelper.GetUserByEmailAsync(User.Identity.Name).ConfigureAwait(false);
            var giras = await _context.Giras
                .Include(x => x.LocalidadVisitada)
                .Where(x => x.Usuario == user)
                .ToListAsync().ConfigureAwait(false);
            return View(giras);
        }

        // GET: Giras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gira = await _context.Giras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gira == null)
            {
                return NotFound();
            }

            return View(gira);
        }

        public IActionResult Create()
        {
            var gira = new GiraViewModel
            {
                Localidades = localidadHelper.GetLocalidadesSelectListItems(),
            };
            return View(gira);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Gira gira)
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

            var gira = await _context.Giras.FindAsync(id).ConfigureAwait(false);
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
                    await _context.SaveChangesAsync().ConfigureAwait(false);
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

            var gira = await _context.Giras
                .FirstOrDefaultAsync(m => m.Id == id).ConfigureAwait(false);
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
            var gira = await _context.Giras.FindAsync(id).ConfigureAwait(false);
            _context.Giras.Remove(gira);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return RedirectToAction(nameof(Index));
        }

        private bool GiraExists(int id)
        {
            return _context.Giras.Any(e => e.Id == id);
        }

        private Gira ToGira(GiraViewModel gVw)
        {
            return new Gira
            {
                Id = gVw.Id,
                Fecha = gVw.Fecha,
                FechaSalida = gVw.FechaSalida,
                FechaRegreso = gVw.FechaRegreso,
                Motivo = gVw.Motivo,
                Dependencia = gVw.Dependencia,
                MontoARESEP = gVw.MontoARESEP,
                Ruta = gVw.Ruta,
                Usuario = gVw.Usuario,
                //Acompanhantes = gVw.Acompanhantes,
                //Gastos = gVw.Gastos,
                TipoTransporte = gVw.TipoTransporte,
                LocalidadVisitada = gVw.LocalidadVisitada,
            };
        }

        private GiraViewModel ToGiraViewModel(Gira gira)
        {
            return new GiraViewModel
            {
                Id = gira.Id,
                Fecha = gira.Fecha,
                FechaSalida = gira.FechaSalida,
                FechaRegreso = gira.FechaRegreso,
                Motivo = gira.Motivo,
                Dependencia = gira.Dependencia,
                MontoARESEP = gira.MontoARESEP,
                Ruta = gira.Ruta,
                Usuario = gira.Usuario,
                //Acompanhantes = gira.Acompanhantes,
                //Gastos = gira.Gastos,
                TipoTransporte = gira.TipoTransporte,
                LocalidadVisitada = gira.LocalidadVisitada,
            };
        }
    }
}
