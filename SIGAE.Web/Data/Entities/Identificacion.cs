using System;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities
{
    public class Identificacion : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Cédula")]
        public String NumIdentificacion { get; set; }
        [Required]
        [Display(Name = "Tipo de identificación")]
        public TipoIdentificacion TipoIdentificacion { get; set; }
        [Display(Name = "Fecha de expedición")]
        public DateTime FechaExpedicion { get; set; }
        [Display(Name = "Fecha de vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        public override string ToString() => $"{this.NumIdentificacion}";
    }
}