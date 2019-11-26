using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Matricula : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Estudiante Estudiante { get; set; }
        [Required]
        [Display(Name = "Curso lectivo")]
        public CursoLectivo CursoLectivo { get; set; }
        public Grupo Grupo { get; set; }
        [Required]
        public string Carnet { get; set; }

        public override string ToString() => this.Estudiante.ToString();
    }
}