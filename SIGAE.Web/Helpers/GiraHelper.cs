using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;

namespace SIGAE.Web.Helpers
{
    public class GiraHelper : IGiraHelper
    {
        private readonly ApplicationDbContext context;

        public GiraHelper(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Gira>> GirasConDependenciasAsync()
        {
            var giras = await context.Giras
                .Include(x => x.LocalidadVisitada)
                //.ThenInclude(l => l.Distrito)
                .Include(x => x.TipoTransporte)
                .Include(x => x.Gastos)
                .Include(x => x.Usuario)
                .Include(x => x.Acompanhantes)
                .ToListAsync();
            return giras;
        }
    }
}
