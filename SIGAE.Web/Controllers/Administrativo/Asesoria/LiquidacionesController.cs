using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using SIGAE.Web.Helpers;

namespace SIGAE.Web.Controllers.Administrativo.Asesoria
{
    [Authorize]
    public class LiquidacionesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserHelper userHelper;

        public LiquidacionesController(ApplicationDbContext context, IUserHelper userHelper)
        {
            _context = context;
            this.userHelper = userHelper;
        }

        // GET: Liquidaciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Liquidaciones.ToListAsync());
        }

        // GET: Liquidaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacion = await _context.Liquidaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacion == null)
            {
                return NotFound();
            }

            return View(liquidacion);
        }

        // GET: Liquidaciones/Create
        public IActionResult Create()
        {
            var l = new Liquidacion();
            //l.Giras = new List<Gira>();
            return View(l);
        }

        // POST: Liquidaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumBoletaLiquidacion,NumBoletaTransporte,FechaSolicitud,FechaAprobacion,Giras,Observaciones,Aceptado")] Liquidacion liquidacion)
        {
            if (ModelState.IsValid)
            {
                var user = await this.userHelper.GetUserByEmailAsync(this.User.Identity.Name);
                liquidacion.Usuario = user;
                _context.Add(liquidacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(liquidacion);
        }

        // GET: Liquidaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacion = await _context.Liquidaciones.FindAsync(id);
            if (liquidacion == null)
            {
                return NotFound();
            }
            return View(liquidacion);
        }

        // POST: Liquidaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumBoletaLiquidacion,NumBoletaTransporte,FechaSolicitud,FechaAprobacion,Observaciones,Aceptado")] Liquidacion liquidacion)
        {
            if (id != liquidacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liquidacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiquidacionExists(liquidacion.Id))
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
            return View(liquidacion);
        }

        // GET: Liquidaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacion = await _context.Liquidaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacion == null)
            {
                return NotFound();
            }

            return View(liquidacion);
        }

        // POST: Liquidaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var liquidacion = await _context.Liquidaciones.FindAsync(id);
            _context.Liquidaciones.Remove(liquidacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiquidacionExists(int id)
        {
            return _context.Liquidaciones.Any(e => e.Id == id);
        }
    }
}
