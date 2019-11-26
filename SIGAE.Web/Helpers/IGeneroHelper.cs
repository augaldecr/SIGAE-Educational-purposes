using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities;
using System.Collections.Generic;

namespace SIGAE.Web.Helpers
{
    public interface IGeneroHelper
    {
        Genero GeneroById(int id);
        IList<Genero> Generos();
        IEnumerable<SelectListItem> GetGenerosSelectListItems();
    }
}