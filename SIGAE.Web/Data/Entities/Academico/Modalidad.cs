namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;

    public class Modalidad : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
