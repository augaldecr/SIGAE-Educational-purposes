namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Canton : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Provincia Provincia { get; set; }

        public virtual IEnumerable<Distrito> Distritos { get; set; }
    }
}
