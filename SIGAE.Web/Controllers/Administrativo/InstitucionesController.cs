﻿using System;
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
    public class InstitucionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstitucionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Instituciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Institucion.ToListAsync());
        }

        // GET: Instituciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institucion = await _context.Institucion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institucion == null)
            {
                return NotFound();
            }

            return View(institucion);
        }

        // GET: Instituciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instituciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoPresupuestario,Nombre,Direccion,Telefono,Email,Lema,LogoURL,Mision,Vision")] Institucion institucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(institucion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(institucion);
        }

        // GET: Instituciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institucion = await _context.Institucion.FindAsync(id);
            if (institucion == null)
            {
                return NotFound();
            }
            return View(institucion);
        }

        // POST: Instituciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoPresupuestario,Nombre,Direccion,Telefono,Email,Lema,LogoURL,Mision,Vision")] Institucion institucion)
        {
            if (id != institucion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(institucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitucionExists(institucion.Id))
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
            return View(institucion);
        }

        // GET: Instituciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institucion = await _context.Institucion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institucion == null)
            {
                return NotFound();
            }

            return View(institucion);
        }

        // POST: Instituciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var institucion = await _context.Institucion.FindAsync(id);
            _context.Institucion.Remove(institucion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstitucionExists(int id)
        {
            return _context.Institucion.Any(e => e.Id == id);
        }
    }
}
