using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Provincia : EntidadBase, IEntity
    {
        [Required]
        [Display(Name = "País")]
        public Pais Pais { get; set; }

        public virtual IEnumerable<Canton> Cantones { get; set; }
    }
}