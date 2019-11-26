using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using System.Collections.Generic;

namespace SIGAE.Web.Models
{
    public class GiraViewModel : Gira
    {
        public IEnumerable<SelectListItem> Localidades { get; set; }
    }
}
