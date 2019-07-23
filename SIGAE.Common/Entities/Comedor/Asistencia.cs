namespace SIGAE.Common.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Asistencia : IEntity
    {
        public int Id { get ; set ; }
        public Matricula Estudiante { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}
