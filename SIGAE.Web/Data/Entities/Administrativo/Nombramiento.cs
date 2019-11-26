using System;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Nombramiento : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Funcionario Funcionario { get; set; }
        [Required]
        [Display(Name = "Institución")]
        public Institucion Institucion { get; set; }
        [Required]
        [Display(Name = "Tipo de nombramiento")]
        public TipoNombramiento TipoNombramiento { get; set; }
        [Required]
        public Puesto Puesto { get; set; }
        [Required]
        [Display(Name = "Fecha de inicio")]
        public DateTime FechaRige { get; set; }
        [Required]
        [Display(Name = "Fecha de vencimiento")]
        public DateTime FechaVence { get; set; }
    }
}
