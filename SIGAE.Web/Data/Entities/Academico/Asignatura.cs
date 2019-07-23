namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;
    public class Asignatura : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
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
