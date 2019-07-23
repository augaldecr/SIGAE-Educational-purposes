namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;

    //Tarea, Extraclase, Práctica
    public class TipoAsignacion : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}