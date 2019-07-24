using SIGAE.Web.Data.Entities;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Models
{
    public class LiquidacionViaticosViewModel
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
        public List<Gira> Giras { get; set; }
        public String Observaciones { get; set; }
        [Required]
        public bool Aceptado { get; set; }
    }
}
