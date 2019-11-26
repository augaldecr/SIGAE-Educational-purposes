using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Academico
{
    public class SubArea : Asignatura
    {
        [Required]
        public Especialidad Especialidad { get; set; }
    }
}
