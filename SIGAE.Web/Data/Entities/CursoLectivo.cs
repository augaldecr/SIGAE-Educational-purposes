using System;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities
{
    public class CursoLectivo : EntidadBase, IEntity
    {
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFinal { get; set; }
    }
}