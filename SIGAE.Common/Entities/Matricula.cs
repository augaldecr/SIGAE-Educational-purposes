namespace SIGAE.Common.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Matricula : IEntity
    {
        public int Id { get ; set ; }
        public Persona Persona { get; set; }
        public CursoLectivo CursoLectivo { get; set; }
        public string Carnet { get; set; }
    }
}
