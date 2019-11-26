using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Distrito : EntidadBase, IEntity
    {
        [Required]
        [Display(Name = "Cantón")]
        public Canton Canton { get; set; }

        public virtual IEnumerable<Localidad> Localidades { get; set; }
    }
}