using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Academico
{
    public class Tema : EntidadBase, IEntity
    {
        [Required]
        public Asignatura Asignatura { get; set; }

        public override string ToString() => $"{this.Nombre} - {this.Asignatura.Nombre}";
    }
}
