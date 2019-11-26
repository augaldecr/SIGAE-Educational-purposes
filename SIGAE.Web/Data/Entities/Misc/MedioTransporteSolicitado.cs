using SIGAE.Web.Data.Entities.Becas;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Misc
{
    public class MedioTransporteSolicitado : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Tipo de medio de transporte")]
        public TipoMedioTransporte TipoMedioTransporte { get; set; }
        [Required]
        public decimal Costo { get; set; }
        public Solicitud Solicitud { get; set; }
    }
}