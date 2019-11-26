namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Canton : EntidadBase, IEntity
    {
        [Required]
        public Provincia Provincia { get; set; }

        public virtual IEnumerable<Distrito> Distritos { get; set; }
    }
}