using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SIGAE.Web.Helpers
{
    public class TipoIdentificacionHelper : ITipoIdentificacionHelper
    {
        private readonly ApplicationDbContext _context;

        public TipoIdentificacionHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetTiposIdentificacionSelectListItems()
        {
            var list = this._context.TiposIdentificacion.Select(t => new SelectListItem
            {
                Text = t.Nombre,
                Value = t.Id.ToString()
            }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione el tipo de identificación",
                Value = "0"
            });

            return list;
        }

        public TipoIdentificacion TiposIdentificacionById(int id)
        {
            return _context.TiposIdentificacion.FirstOrDefault(x => x.Id == id);
        }

        public IList<TipoIdentificacion> TiposIdentificacion()
        {
            return _context.TiposIdentificacion.ToList();
        }
    }
}