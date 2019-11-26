using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Becas
{
    public class Beca : EntidadBase, IEntity
    {
        [Display(Name ="Tipo de beca")]
        public TipoBeca TipoBeca { get; set; }
    }
}