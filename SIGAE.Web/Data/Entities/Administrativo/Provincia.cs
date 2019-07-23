namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Provincia : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "País")]
        public Pais Pais { get; set; }

        public virtual IEnumerable<Canton> Cantones { get; set; }
    }
}
