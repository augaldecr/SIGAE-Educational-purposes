using System;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Comedor
{
    public class Asistencia
    {
        public int Id { get; set; }
        //public Matricula Estudiante { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}
