namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class TipoTransporte : IEntity
    {
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
    }
}
