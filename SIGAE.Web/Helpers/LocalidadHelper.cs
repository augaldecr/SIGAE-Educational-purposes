using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo;

namespace SIGAE.Web.Helpers
{
    public class LocalidadHelper : ILocalidadHelper
    {
        private readonly ApplicationDbContext context;

        public LocalidadHelper(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetLocalidadesSelectListItems()
        {
            var list = this.context.Localidades.Select(t => new SelectListItem
            {
                Text = t.ToString(),
                Value = t.Id.ToString()
            }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione la localidad",
                Value = "0"
            });

            return list;
        }
    }
}
