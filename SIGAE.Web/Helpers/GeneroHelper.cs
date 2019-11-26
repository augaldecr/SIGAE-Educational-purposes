using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SIGAE.Web.Helpers
{
    public class GeneroHelper : IGeneroHelper
    {
        private readonly ApplicationDbContext applicationDbContext;

        public GeneroHelper(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Genero GeneroById(int id)
        {
            return applicationDbContext.Generos.FirstOrDefault(x => x.Id == id);
        }

        public IList<Genero> Generos()
        {
            return applicationDbContext.Generos.ToList();
        }

        public IEnumerable<SelectListItem> GetGenerosSelectListItems()
        {
            var list = this.applicationDbContext.Generos.Select(t => new SelectListItem
            {
                Text = t.Nombre,
                Value = t.Id.ToString()
            }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione el género",
                Value = "0"
            });

            return list;
        }
    }
}