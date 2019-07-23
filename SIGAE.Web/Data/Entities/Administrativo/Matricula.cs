namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;

    public class Matricula : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Persona Persona { get; set; }
        public Grupo Grupo { get; set; }
        [Required]
        public string Carnet { get; set; }
    }
}
