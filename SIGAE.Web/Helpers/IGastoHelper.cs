using System.Collections.Generic;
using System.Threading.Tasks;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;

namespace SIGAE.Web.Helpers
{
    public interface IGastosHelper
    {
        Task<Gasto> GastoByIdAsync(int id);
        IList<Gasto> GastosByUser(User user);
        IList<Gasto> GastosNoAsignadosByUser(User user);
    }
}