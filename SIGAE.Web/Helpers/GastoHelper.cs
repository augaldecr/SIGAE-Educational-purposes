using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Helpers
{
    public class GastoHelper : IGastosHelper
    {
        private readonly ApplicationDbContext context;

        public GastoHelper(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Gasto> GastoByIdAsync(int id)
        {
            var gasto = context.Gastos
                .Include(x => x.Usuario)
                .Include(x => x.TipoGasto)
                .FirstOrDefaultAsync(g => g.Id == id);
                
            return await gasto.ConfigureAwait(true);
        }

        public IList<Gasto> GastosByUser(User user)
        {
            return this.context.Gastos
                .Where(g => g.Usuario == user)
                .OrderBy(g => g.Id).ToList();
        }

        public IList<Gasto> GastosNoAsignadosByUser(User user)
        {
            return this.context.Gastos
                .Where(g => g.Usuario == user && g.Asignado == false)
                .OrderBy(g => g.Id).ToList();
        }
    }
}
