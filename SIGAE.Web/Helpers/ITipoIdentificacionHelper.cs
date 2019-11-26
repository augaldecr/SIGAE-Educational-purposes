using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities;
using System.Collections.Generic;

namespace SIGAE.Web.Helpers
{
    public interface ITipoIdentificacionHelper
    {
        IList<TipoIdentificacion> TiposIdentificacion();
        IEnumerable<SelectListItem> GetTiposIdentificacionSelectListItems();
        TipoIdentificacion TiposIdentificacionById(int id);
    }
}
