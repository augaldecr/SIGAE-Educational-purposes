namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    //Pueblo, ciudad, villa
    public class Localidad : EntidadBase, IEntity
    {
        [Required]
        public Distrito Distrito { get; set; }

        public virtual IEnumerable<Institucion> Instituciones { get; set; }

        public override string ToString() => $"{Nombre} - {Distrito.Nombre}";
    }
}