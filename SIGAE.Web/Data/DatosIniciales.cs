using Microsoft.AspNetCore.Identity;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Data.Entities.Administrativo;
using SIGAE.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Data
{
    public class DatosIniciales
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;
        private readonly IdentificacionHelper identificacionHelper;

        public DatosIniciales(ApplicationDbContext context, UserManager<User> userManager, 
            IdentificacionHelper identificacionHelper)
        {
            this.context = context;
            this.userManager = userManager;
            this.identificacionHelper = identificacionHelper;
        }

        public async Task Inicializar()
        {
            Pais CostaRica = new Pais { Nombre = "Costa Rica" };
            Provincia Limon = new Provincia { Nombre = "Limón", Pais = CostaRica };
            Canton Pococi = new Canton { Nombre = "Pococí", Provincia = Limon };
            Distrito Guapiles = new Distrito { Nombre = "Guápiles", Canton = Pococi };
            Localidad GuapilesCentro = new Localidad { Nombre = "Guápiles centro", Distrito = Guapiles };

            Identificacion identificacion = new Identificacion { NumIdentificacion = "7-0155-0999" };
            identificacionHelper.SaveIdentificacion(identificacion);
            var cedula = identificacionHelper.GetIdentificacionXCedula("7-0155-0999");

            Persona AlonsoUgalde = new Persona
            {
                Identificacion = cedula,
                Nombre = "Alonso",
                Apellido1 = "Ugalde",
                Apellido2 = "Aguilar",
                Email = "augaldecr@gmail.com",
                Celular = "88888888"
            };

            if (!this.context.Paises.Any())
            {
                await context.Paises.AddAsync(CostaRica).ConfigureAwait(false);
                await context.Provincias.AddAsync(Limon).ConfigureAwait(false);
                await context.Cantones.AddAsync(Pococi).ConfigureAwait(false);
                await context.Distritos.AddAsync(Guapiles).ConfigureAwait(false);
                await context.Localidades.AddAsync(GuapilesCentro).ConfigureAwait(false);
                await context.SaveChangesAsync().ConfigureAwait(false);
            }
            if (!this.context.Personas.Any())
            {
                await context.Personas.AddAsync(AlonsoUgalde).ConfigureAwait(true);
                await context.SaveChangesAsync().ConfigureAwait(false);
            }

            var usuario = await userManager.FindByEmailAsync("augaldecr@gmail.com").ConfigureAwait(false);
            if (usuario == null)
            {
                usuario = new User
                {
                    Persona = AlonsoUgalde,
                    Email = "augaldecr@gmail.com",
                    UserName = "augaldecr@gmail.com"
                };

                var result = await userManager.CreateAsync(usuario, "123456").ConfigureAwait(false);
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("No se puede crear el usuario");
                }
            }
        }
    }
}