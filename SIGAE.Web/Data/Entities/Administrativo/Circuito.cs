namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Circuito : EntidadBase, IEntity
    {
        [Required]
        public Regional Regional { get; set; }

        public virtual IEnumerable<Institucion> Instituciones { get; set; }
    }
}