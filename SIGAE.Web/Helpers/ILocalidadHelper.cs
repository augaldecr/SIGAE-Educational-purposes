using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Helpers
{
    public interface ILocalidadHelper
    {
        IEnumerable<SelectListItem> GetLocalidadesSelectListItems();
    }
}
