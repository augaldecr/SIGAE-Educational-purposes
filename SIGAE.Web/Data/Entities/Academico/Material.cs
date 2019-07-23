namespace SIGAE.Web.Data.Entities.Academico
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Misc;
    //Material para apoyar la mediación educativa
    public class Material : Publicacion
    {
        [Required]
        public IEnumerable<Archivo> Archivos { get; set; }
    }
}
