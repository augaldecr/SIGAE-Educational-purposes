using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Helpers;
using SIGAE.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Controllers
{
    public class PersonasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IIdentificacionHelper identificacionHelper;
        private readonly ITipoIdentificacionHelper tiposIdentificacionHelper;
        private readonly IGeneroHelper generoHelper;

        public PersonasController(ApplicationDbContext context,
            IIdentificacionHelper identificacionHelper,
            ITipoIdentificacionHelper tiposIdentificacionHelper,
            IGeneroHelper generoHelper)
        {
            _context = context;
            this.identificacionHelper = identificacionHelper;
            this.tiposIdentificacionHelper = tiposIdentificacionHelper;
            this.generoHelper = generoHelper;
        }

        public async Task<IActionResult> Index()
        {
            var personas = _context.Personas
                .Include(x => x.Identificacion)
                .Include(x => x.Genero)
                .ToListAsync();
            return View(await personas);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .Include(x => x.Genero)
                .Include(x => x.Identificacion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        public IActionResult Create()
        {
            var pVw = new PersonaViewModel
            {
                TiposIdentificacion = tiposIdentificacionHelper.GetTiposIdentificacionSelectListItems(),
                Generos = generoHelper.GetGenerosSelectListItems()
            };
            return View(pVw);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaViewModel pwm)
        {
            if (ModelState.IsValid)
            {
                var tipoIdentificacion =
                    tiposIdentificacionHelper.TiposIdentificacionById(pwm.TipoIdentificacionId);

                var genero = generoHelper.GeneroById(pwm.GeneroId);

                var identificacion = new Identificacion
                {
                    TipoIdentificacion = tipoIdentificacion,
                    NumIdentificacion = pwm.NumCedula
                };

                identificacionHelper.SaveIdentificacion(identificacion);

                var identif = identificacionHelper.GetIdentificacionXCedula(pwm.NumCedula);

                var persona = ToPersona(pwm);

                persona.Genero = genero;
                persona.Identificacion = identif;

                _context.Add(persona);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction(nameof(Index));
            }
            return View(pwm);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .Include(x => x.Identificacion)
                .ThenInclude(x => x.TipoIdentificacion)
                .Include(x => x.Genero)
                .FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            if (persona == null)
            {
                return NotFound();
            }

            var personaVw = ToPersonaVw(persona);
            personaVw.TiposIdentificacion = tiposIdentificacionHelper
                .GetTiposIdentificacionSelectListItems();
            personaVw.Generos = generoHelper.GetGenerosSelectListItems();

            return View(personaVw);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PersonaViewModel pVw)
        {
            if (id != pVw.Id)
            {
                return NotFound();
            }

            var persona = ToPersona(pVw);


            var identificacion = identificacionHelper.GetIdentificacion(pVw.IdentificacionId);

            identificacion.TipoIdentificacion = 
                tiposIdentificacionHelper.TiposIdentificacionById(pVw.TipoIdentificacionId);

            if (identificacion.NumIdentificacion != pVw.NumCedula)
            {
                identificacion.NumIdentificacion = pVw.NumCedula;
                identificacionHelper.UpdateIdentificacion(identificacion);
            }

            persona.Identificacion = identificacion;

            persona.Genero = generoHelper.GeneroById(pVw.GeneroId);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync().ConfigureAwait(true);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
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
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas.FirstOrDefaultAsync(m => m.Id == id).ConfigureAwait(true);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Personas.FindAsync(id).ConfigureAwait(true);
            var identificacion = identificacionHelper.GetIdentificacion(persona.Identificacion.Id);
            _context.Identificaciones.Remove(identificacion);
            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync().ConfigureAwait(true);
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.Id == id);
        }

        private Persona ToPersona(PersonaViewModel pwm)
        {
            return new Persona
            {
                Id = pwm.Id,
                Identificacion = pwm.Identificacion,
                Nombre = pwm.Nombre,
                Apellido1 = pwm.Apellido1,
                Apellido2 = pwm.Apellido2,
                Email = pwm.Email,
                Celular = pwm.Celular,
                FechaNacimiento = pwm.FechaNacimiento,
                Genero = pwm.Genero
            };
        }

        private PersonaViewModel ToPersonaVw(Persona persona)
        {
            return new PersonaViewModel
            {
                Id = persona.Id,
                NumCedula = persona.Identificacion.NumIdentificacion,
                Nombre = persona.Nombre,
                Apellido1 = persona.Apellido1,
                Apellido2 = persona.Apellido2,
                Celular = persona.Celular,
                Email = persona.Email,
                FechaNacimiento = persona.FechaNacimiento,
                Genero = persona.Genero,
                GeneroId = persona.Genero.Id,
                Identificacion = persona.Identificacion,
                TipoIdentificacionId = persona.Identificacion.TipoIdentificacion.Id,
                IdentificacionId = persona.Identificacion.Id
            };
        }
    }
}
