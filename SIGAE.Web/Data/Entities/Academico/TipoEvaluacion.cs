namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;
    //Trimestral, Semestral, Unisemestral, Sin evaluación
    public class TipoEvaluacion : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}