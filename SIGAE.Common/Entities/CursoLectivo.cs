namespace SIGAE.Common.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class CursoLectivo : IEntity
    {
        public int Id { get ; set ; }
        [Required]
        public string Anio { get; set; }
    }
}
