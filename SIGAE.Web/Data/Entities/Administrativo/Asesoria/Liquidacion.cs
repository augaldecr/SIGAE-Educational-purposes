using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    public class Liquidacion : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Boleta de liquidación N")]
        public String NumBoletaLiquidacion { get; set; }
        [Required]
        [Display(Name = "Boleta de transporte N")]
        public String NumBoletaTransporte { get; set; }
        [Required]
        [Display(Name = "Fecha de solicitud")]
        public DateTime FechaSolicitud { get; set; }
        [Required]
        [Display(Name = "Fecha de aprobación")]
        public DateTime FechaAprobacion { get; set; }
        [Required]
        public User Usuario { get; set; }
        [Required]
        public virtual IList<Gira> Giras { get; }
        public String Observaciones { get; set; }
        [Required]
        public bool Aceptado { get; set; }

        public override string ToString() => $"{this.Usuario.Persona.NombreCorto()} {this.FechaSolicitud}";   
    }
}