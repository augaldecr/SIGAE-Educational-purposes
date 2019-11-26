using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using SIGAE.Web.Helpers;
using SIGAE.Web.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Controllers.Administrativo.Asesoria
{
    public class GastosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITiposGastoHelper tiposGastoHelper;
        private readonly IUserHelper userHelper;
        private readonly IGastosHelper gastosHelper;

        public GastosController(ApplicationDbContext context,
            ITiposGastoHelper tiposGastoHelper,
            IUserHelper userHelper, 
            IGastosHelper gastosHelper)
        {
            _context = context;
            this.tiposGastoHelper = tiposGastoHelper;
            this.userHelper = userHelper;
            this.gastosHelper = gastosHelper;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userHelper.GetUserByEmailAsync(User.Identity.Name).ConfigureAwait(false);
            return View(_context.Gastos.Where(g => g.Usuario == user)
                .Include(g => g.TipoGasto));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gasto = await _context.Gastos
                .Include(m => m.TipoGasto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gasto == null)
            {
                return NotFound();
            }

            return View(gasto);
        }

        public IActionResult Create()
        {
            var model = new GastoViewModel
            {
                TiposGasto = this.tiposGastoHelper.GetTiposGastosSelectListItems()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GastoViewModel gasto)
        {
            if (ModelState.IsValid)
            {
                var path = string.Empty;

                if (gasto.FacturaImg != null && gasto.FacturaImg.Length > 0)
                {
                    var guid = Guid.NewGuid().ToString();
                    var file = $"{guid}.jpg";

                    path = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot\\images\\Facturas", file);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await gasto.FacturaImg.CopyToAsync(stream);
                    }
                    path = $"~/images/Facturas/{file}";
                }

                gasto.Usuario = await this.userHelper.GetUserByEmailAsync(this.User.Identity.Name);
                gasto.Factura = path;
                gasto.TipoGasto = this.tiposGastoHelper.TipoGastoById(gasto.TipoGastoId);

                Gasto g = ToGasto(gasto);

                await _context.AddAsync<Gasto>(g);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gasto);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gasto = await this.gastosHelper.GastoByIdAsync((int)id);
            if (gasto == null)
            {
                return NotFound();
            }
            var gastoVw = this.ToGastoViewModel(gasto);
            gastoVw.TiposGasto = this.tiposGastoHelper.GetTiposGastosSelectListItems();
            return View(gastoVw);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, GastoViewModel gastoVw)
        {
            if (id != gastoVw.Id)
            {
                return NotFound();
            }

            var gasto = ToGasto(gastoVw);

            if (ModelState.IsValid)
            {
                try
                {
                    var path = gastoVw.Factura;

                    if (gastoVw.FacturaImg != null && gastoVw.FacturaImg.Length > 0)
                    {
                        var guid = Guid.NewGuid().ToString();
                        var file = $"{guid}.jpg";

                        path = Path.Combine(Directory.GetCurrentDirectory(),
                            "wwwroot\\images\\Facturas", file);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await gastoVw.FacturaImg.CopyToAsync(stream);
                        }
                        path = $"~/images/Facturas/{file}";
                    }

                    gasto.Factura = path;

                    _context.Update(gasto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GastoExists(gasto.Id))
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
            return View(gasto);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gasto = await _context.Gastos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gasto == null)
            {
                return NotFound();
            }

            return View(gasto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gasto = await _context.Gastos.FindAsync(id);
            _context.Gastos.Remove(gasto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GastoExists(int id)
        {
            return _context.Gastos.Any(e => e.Id == id);
        }

        private Gasto ToGasto(GastoViewModel model)
        {
            return new Gasto
            {
                Id = model.Id,
                Factura = model.Factura,
                Monto = model.Monto,
                TipoGasto = model.TipoGasto,
                Usuario = model.Usuario,
                Asignado = model.Asignado,
            };
        }

        private GastoViewModel ToGastoViewModel(Gasto g)
        {
            return new GastoViewModel
            {
                Id = g.Id,
                Asignado = g.Asignado,
                Factura = g.Factura,
                Monto = g.Monto,  
                Usuario = g.Usuario,
                TipoGasto = g.TipoGasto,
                TipoGastoId = g.TipoGasto.Id,
            };
        }
    }
}