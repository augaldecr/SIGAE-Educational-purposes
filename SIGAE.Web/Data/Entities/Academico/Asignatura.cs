using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Academico
{
    public class Asignatura : EntidadBase, IEntity
    {
        //Básica, Complementaria, Técnica, Ciencia, Conducta
        [Required]
        [Display(Name = "Tipo de asignatura")]
        public TipoAsignatura TipoAsignatura { get; set; }
        //Trimestral, Semestral, Unisemestral, Sin evaluación
        [Required]
        [Display(Name = "Tipo de evaluación")]
        public TipoEvaluacion TipoEvaluacion { get; set; }
    }
}
