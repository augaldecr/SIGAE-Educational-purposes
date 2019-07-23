using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    //Secretaria, asistente, director, orientador, docente
    public class Puesto : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Tipo de puesto")]
        public TipoPuesto TipoPuesto { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}