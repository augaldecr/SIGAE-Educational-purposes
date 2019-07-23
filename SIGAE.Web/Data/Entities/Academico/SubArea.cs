namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;
    public class SubArea : Asignatura
    {
        [Required]
        public Especialidad Especialidad { get; set; }
    }
}
