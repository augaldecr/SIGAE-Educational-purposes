using SIGAE.Web.Data.Entities.Administrativo;
using SIGAE.Web.Data.Entities.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Academico
{
    public class Asignacion : Publicacion
    {
        public int Puntos { get; set; }
        [Required]
        [Display(Name = "Puntaje obtenido")]
        public int? PuntajeObtenido { get; set; }
        [Display(Name = "Calificación obtenida")]
        public float Calificacion { get; set; }
        [Required]
        [Display(Name = "Fecha de disponibilidad")]
        public DateTime FechaDisponibilidad { get; set; }
        [Required]
        [Display(Name = "Fecha de entrega")]
        public DateTime FechaEntrega { get; set; }
        [Required]
        public IEnumerable<Grupo> Grupos { get; set; }
        [Display(Name = "Archivos adjuntos")]
        public IEnumerable<Archivo> Archivos { get; set; }
        //Tarea, práctica, trabajo en clase
        [Required]
        [Display(Name = "Tipo de asignación")]
        public TipoAsignacion TipoAsignacion { get; set; }
    }
}
