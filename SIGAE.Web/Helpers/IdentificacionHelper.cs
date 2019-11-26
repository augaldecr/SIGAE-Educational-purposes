using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using System.Linq;

namespace SIGAE.Web.Helpers
{
    public class IdentificacionHelper : IIdentificacionHelper
    {
        private readonly ApplicationDbContext applicationDbContext;

        public IdentificacionHelper(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Identificacion GetIdentificacionXCedula(string cedula)
        {
            return applicationDbContext.Identificaciones.FirstOrDefault(i => i.NumIdentificacion == cedula);
        }

        public Identificacion GetIdentificacion(int id) {
            return applicationDbContext.Identificaciones.FirstOrDefault(i => i.Id == id);
        }

        public async void SaveIdentificacion(Identificacion identificacion)
        {
            await applicationDbContext.Identificaciones.AddAsync(identificacion);
            await applicationDbContext.SaveChangesAsync();
        }

        public void UpdateIdentificacion(Identificacion identificacion)
        {
            applicationDbContext.Identificaciones.Update(identificacion);
            applicationDbContext.SaveChangesAsync();
        }
    }
}
