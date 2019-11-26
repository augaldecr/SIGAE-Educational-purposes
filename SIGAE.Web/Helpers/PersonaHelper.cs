using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using System.Linq;

namespace SIGAE.Web.Helpers
{
    public class PersonaHelper : IPersonaHelper
    {
        private readonly ApplicationDbContext context;

        public PersonaHelper(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Persona GetPersonaXCedula(string cedula)
        {
            return context.Personas.FirstOrDefault(p => p.Identificacion.NumIdentificacion == cedula);
        }

        public void SavePersona(Persona persona)
        {
            context.Personas.Add(persona);
        }

        public void UpdatePersona(Persona persona)
        {
            context.Personas.Update(persona);
            context.SaveChangesAsync();
        }

        public Persona GetPersonaXEmail(string email)
        {
            return this.context.Personas.FirstOrDefault(p => p.Email == email);
        }
    }
}