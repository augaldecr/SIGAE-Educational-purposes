namespace SIGAE.Web.Helpers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Data;
    using Data.Entities.Administrativo.Asesoria;

    public class TiposGastoHelper : ITiposGastoHelper
    {
        private readonly ApplicationDbContext context;

        public TiposGastoHelper(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetTiposGastosSelectListItems()
        {
            var list = this.context.TiposGasto.Select(t => new SelectListItem
            {
                Text = t.Nombre,
                Value = t.Id.ToString()
            }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione el tipo de gasto",
                Value = "0"
            });

            return list;
        }

        public IList<TipoGasto> TiposGasto()
        {
            return this.context.TiposGasto.ToList();
        }

        public TipoGasto TipoGastoById(int id)
        {
            return this.context.TiposGasto.FirstOrDefault(t => t.Id == id);
        }
    }
}
