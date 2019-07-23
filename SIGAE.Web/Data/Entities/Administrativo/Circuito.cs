namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Circuito : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Regional Regional { get; set; }

        public virtual IEnumerable<Institucion> Instituciones { get; set; }
    }
}
