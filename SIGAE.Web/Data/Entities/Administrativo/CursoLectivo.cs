using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class CursoLectivo : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Año")]
        public string Anio { get; set; }
        public bool Actual { get; set; }

        public virtual IEnumerable<Grupo> Grupos { get; set; }
    }
}