namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    //Pueblo, ciudad, villa
    public class Localidad : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Distrito Distrito { get; set; }

        public virtual IEnumerable<Institucion> Instituciones { get; set; }
    }
}
