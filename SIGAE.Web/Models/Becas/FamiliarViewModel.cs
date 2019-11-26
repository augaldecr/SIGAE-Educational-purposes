using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities.Becas;
using System.Collections.Generic;

namespace SIGAE.Web.Models.Becas
{
    public class FamiliarViewModel
    {
        public int Id { get; set; }
        public Parentesco Parentesco { get; set; }

        public int ParentescoId { get; set; }

        public IEnumerable<SelectListItem> Parentescos { get; set; }
    }
}