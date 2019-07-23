namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Grupo : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Nivel Nivel { get; set; }
        [Required]
        [Display(Name = "Sección")]
        public string Seccion { get; set; }
        [Required]
        [Display(Name = "Curso lectivo")]
        public CursoLectivo CursoLectivo { get; set; }
        [Required]
        [Display(Name = "Institución")]
        public Institucion Institucion { get; set; }

        public virtual IEnumerable<Matricula> Estudiantes { get; set; }

        public override string ToString()
        {
            return $"{Nivel.Nombre}-{Seccion} - {CursoLectivo.Anio}";
        }
    }
}
