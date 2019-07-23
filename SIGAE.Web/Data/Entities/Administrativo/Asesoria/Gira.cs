namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Gira : IEntity
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        [Display(Name = "Fecha de salida")]
        public DateTime FechaSalida { get; set; }
        [Required]
        [Display(Name = "Fecha de regreso")]
        public DateTime FechaRegreso { get; set; }
        [Required]
        public String Motivo { get; set; }
        [Required]
        [Display(Name = "Localidad visitada")]
        public Localidad LocalidadVisitada { get; set; }
        [Required]
        public String Dependencia { get; set; }
        public List<Funcionario> Acompañantes { get; set; }
        [Required]
        [Display(Name = "Transporte")]
        public TipoTransporte TipoTransporte { get; set; }
        [Required]
        public String Ruta { get; set; }
        [Required]
        [Display(Name = "Monto según ARESEP")]
        public int MontoARESEP { get; set; }
        [Required]
        public List<Gasto> Gastos { get; set; }
        public User Usuario { get; set; }
    }
}
