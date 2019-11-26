using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Helpers
{
    public interface IGiraHelper
    {
        Task<List<Gira>> GirasConDependenciasAsync();
    }
}
