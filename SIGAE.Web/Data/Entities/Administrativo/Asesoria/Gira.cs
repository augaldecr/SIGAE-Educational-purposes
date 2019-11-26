using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    public class Gira : IEntity
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd tt}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de salida")]
        public DateTime FechaSalida { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd tt}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de regreso")]
        public DateTime FechaRegreso { get; set; }
        [Required]
        public String Motivo { get; set; }
        [Required]
        [Display(Name = "Localidad visitada")]
        public Localidad LocalidadVisitada { get; set; }
        [Required]
        public String Dependencia { get; set; }
        [Display(Name = "Acompañantes")]
        public virtual IList<Funcionario> Acompanhantes { get; }
        [Required]
        [Display(Name = "Transporte")]
        public TipoTransporte TipoTransporte { get; set; }
        [Required]
        public String Ruta { get; set; }
        [Required]
        [Display(Name = "Monto según ARESEP")]
        public int MontoARESEP { get; set; }
        [Required]
        public virtual IList<Gasto> Gastos { get; }
        public User Usuario { get; set; }
    }
}