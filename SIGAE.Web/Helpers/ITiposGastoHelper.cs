using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;

namespace SIGAE.Web.Helpers
{
    public interface ITiposGastoHelper
    {
        IList<TipoGasto> TiposGasto();
        IEnumerable<SelectListItem> GetTiposGastosSelectListItems();
        TipoGasto TipoGastoById(int id);
    }
}