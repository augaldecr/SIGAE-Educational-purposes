using SIGAE.Web.Data.Entities.Misc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Academico
{
    //Material para apoyar la mediación educativa
    public class Material : Publicacion
    {
        [Required]
        public IEnumerable<Archivo> Archivos { get; set; }
    }
}
