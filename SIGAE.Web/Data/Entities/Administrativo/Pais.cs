namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Pais : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public virtual IEnumerable<Provincia> Provincias { get; set; }
    }
}
